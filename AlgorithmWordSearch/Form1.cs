using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AlgorithmWordSearch.Models;

namespace AlgorithmWordSearch
{
	public partial class DocumentWordSearch : Form
	{		
		List<Document> Documents = new List<Document>();

		DataTable SearchOptions = new DataTable();
		DataTable Files = new DataTable();

		public DocumentWordSearch()
		{
			InitializeComponent();

			//searchPerimeters.Add(new SearchPerimeter(SearchType.AND, "dskasdasd"));
			//dataRepeater1.DataSource = searchPerimeters;
			//dataRepeater1.ItemTemplate.DataBindings.Add(new Binding("SearchType", searchPerimeters[0], "SearchType"));
			//dataRepeater1.ItemTemplate.DataBindings.Add(new Binding("Value", searchPerimeters, "Value"));

			
			// defaults
			comboBox1.Items.AddRange(new string[]{"AND", "OR"});
			comboBox1.SelectedText = "AND";
			
			// Search Options bind
			SearchOptions.Columns.Add("SearchOption");
			SearchOptions.Columns.Add("SearchType");
			SearchOptions.Rows.Add("","AND");

			textBox1.DataBindings.Add("Text", SearchOptions, "SearchOption");
			comboBox1.DataBindings.Add("Text", SearchOptions, "SearchType");
			dataRepeater1.DataSource = SearchOptions;

			
			// Uploaded Files bind
			Files.Columns.Add("File Location");

			label3.DataBindings.Add("Text", Files, "File Location");
			dataRepeater2.DataSource = Files;


			// Document Results Bind
			documentComboBox.DataBindings.Add("Text", Documents, "Path");
			documentComboBox.DataSource = Documents;
			

			tabControl1.TabPages[1].Hide();
			progressBar1.Hide();

		}

		private void AddNewSearchOption(object sender, EventArgs e)
		{
			SearchOptions.Rows.Add("", "AND");
		}

		private void RemoveSearchOption(object sender, EventArgs e)
		{
			SearchOptions.Rows.RemoveAt(dataRepeater1.CurrentItem.ItemIndex);
		}


		/// <summary>
		/// Based my upload function on this article.
		/// 
		/// http://voices.yahoo.com/how-create-browse-file-dialog-box-c-6141416.html
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Upload(object sender, EventArgs e)
		{
			// Call a browse files dialog box

			// Intialize variables

			string strDirectory = "C:/Users/Dominic Northey/Documents/Work/Notes/Year 6/Sem 1/Algorithms";

			// Open the dialog box

			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			openFileDialog1.InitialDirectory = strDirectory;

			openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 1;
			openFileDialog1.Multiselect = true;
			openFileDialog1.RestoreDirectory = true;

			DialogResult Result = openFileDialog1.ShowDialog();

			// Load the image to the load image picture box

			if (Result == DialogResult.OK)
			{				
				foreach(string filename in openFileDialog1.FileNames)
				{
					Files.Rows.Add(filename);

					Document doc = new Document();

					doc.Path = filename;

					List<string> sentences = System.IO.File.ReadAllLines(filename).ToList();
					List<string> splitSentences = new List<string>();

					sentences.ForEach(x => splitSentences.AddRange(x.Split('.')));
					
					for (int count = 0; count < splitSentences.Count; count++)
					{	
						if (string.IsNullOrEmpty(splitSentences[count])) continue;
						
						doc.Sentences.Add
						(
							new Sentence(doc)
							{
								Value = splitSentences[count] + '.',
								Position = count
							}
						);
					}

					Documents.Add(doc);
				}
			}


		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void Search(object sender, EventArgs e)
		{
			if (!new DocumentSearcher(Documents, GetSearchPerimeters()).Search()) return;

			// Clear Old results
			importanceTextBox.DataBindings.Clear();
			positionLabel1.DataBindings.Clear();
			valueTextBox.DataBindings.Clear();

			// Results Bind

			importanceTextBox.DataBindings.Add("Text", Documents[0].MatchingSentences, "Importance");
			positionLabel1.DataBindings.Add("Text", Documents[0].MatchingSentences, "Position");
			valueTextBox.DataBindings.Add("Text", Documents[0].MatchingSentences, "Value");
			sentencesDataRepeater.DataSource = Documents[0].MatchingSentences;

			tabControl1.TabPages[1].Show();
			tabControl1.SelectedIndex = 1;
		}

		private List<SearchPerimeter> GetSearchPerimeters()
		{
			List<SearchPerimeter> searchPerimeters = new List<SearchPerimeter>();

			foreach (DataRow row in SearchOptions.Rows)
			{
				if (string.IsNullOrEmpty(row.ItemArray[0].ToString())) continue;

				searchPerimeters.Add(
					new SearchPerimeter(
						(SearchType)Enum.Parse(
							typeof(SearchType),
							row.ItemArray[1].ToString(),
							true),
						row.ItemArray[0].ToString()));
			}
			return searchPerimeters;
		}
	}
}