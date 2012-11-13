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

			

			comboBox1.Items.AddRange(new string[]{"AND", "OR"});
			comboBox1.SelectedText = "AND";


			SearchOptions.Columns.Add("SearchOption");
			SearchOptions.Columns.Add("SearchType");

			dataRepeater1.DataSource = SearchOptions;
			
			SearchOptions.Rows.Add("","AND");

			//textBox1.DataBindings.Add("SearchOptn", SearchOptions, "SearchOption");
			//comboBox1.DataBindings.Add("SearchBy", SearchOptions, "SearchType");

			Files.Columns.Add("File Location");

			dataRepeater2.DataSource = Files;


			progressBar1.Hide();

		}

		private void Search(object sender, EventArgs e)
		{
			new DocumentSearcher(Documents, GetSearchPerimeters()).Search();
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

			Console.WriteLine("Directory: " + strDirectory);

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

					System.IO.File.ReadAllLines(openFileDialog1.FileName).ToList().ForEach(
						x => doc.Sentences.Add(new Sentence(doc){Value = x}));

					Documents.Add(doc);

					dataRepeater2.CurrentItem.Controls.Find("label3", false).First().Text = filename;
					
					//Files.Rows.Count-1
					
				}
			}


		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}
	}
}