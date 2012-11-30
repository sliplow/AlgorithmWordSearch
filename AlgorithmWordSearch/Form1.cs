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

			fileLocations.DataBindings.Add("Text", Files, "File Location");
			dataRepeater2.DataSource = Files;
			
			tabControl1.TabPages[1].Hide();
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

					List<string> sentences = new List<string>();
					
					foreach(string line in System.IO.File.ReadAllLines(filename))
					{
						sentences.AddRange(line.Split('.').ToList());
					}

					// Remove null or empty
					List<string> splitSentences = sentences.Where(x => !string.IsNullOrEmpty(x)).ToList();

					for (int count = 0; count < splitSentences.Count; count++)
					{							
						doc.Sentences.Add
						(
							new Sentence(doc)
							{
								Value = splitSentences[count] + '.',
								Position = count + 1
							}
						);
					}

					Documents.Add(doc);
				}
			}
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

		private void Search(object sender, EventArgs e)
		{
			if (!new DocumentSearcher(Documents, GetSearchPerimeters()).Search())
			{
				MessageBox.Show("Search did not return any Results.");
				return;
			}
			
			Documents = Documents.OrderByDescending(y => y.Importance).ToList();
		
			documentComboBox.Items.Clear();
			documentComboBox.DataBindings.Clear();

			// Document Results Bind
			documentComboBox.Items.AddRange(Documents.Select(x => x.Path).ToArray());

			SetResultsToDocument(Documents[0]);

			// Show Results tab
			tabControl1.TabPages[1].Show();
			tabControl1.SelectedIndex = 1;
		}

		private void SetResultsToDocument(Document doc)
		{
			documentComboBox.SelectedItem = doc;
			//documentComboBox.SelectedText = doc.Path;
			//documentComboBox.SelectedValue = doc.Path;

			// Clear Old results
			importanceTextBox.DataBindings.Clear();
			positionLabel1.DataBindings.Clear();
			valueTextBox.DataBindings.Clear();

			// Results Bind

			fileImportance.Text = Math.Round(doc.Importance, 2).ToString();
			importanceTextBox.DataBindings.Add("Text", doc.MatchingSentences, "Importance");
			positionLabel1.DataBindings.Add("Text", doc.MatchingSentences, "Position");
			valueTextBox.DataBindings.Add("Text", doc.MatchingSentences, "Value");
			sentencesDataRepeater.DataSource = doc.MatchingSentences;
		}

		public void SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string text = ((ComboBox)sender).SelectedItem.ToString();
			
			if(!Documents.Exists(x => x.Path == text)) return;

			SetResultsToDocument(Documents.First(x => x.Path == text));
		}
	}
}