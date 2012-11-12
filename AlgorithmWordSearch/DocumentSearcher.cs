using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgorithmWordSearch.Models;

namespace AlgorithmWordSearch
{
	public class DocumentSearcher
	{
		public List<Document> Documents { get; set; }
		public List<SearchPerimeter> SearchPerimeters { get; set; }
		
		public DocumentSearcher(
			List<Document> inputDocuments,
			List<SearchPerimeter> searchPerimeters)
		{
			Documents = inputDocuments;
			SearchPerimeters = searchPerimeters;
		}

		public bool Search()
		{
			if (SearchPerimeters.Count == 0) return false;
					
			ReorderSearchesByAnd();

			//bool isNotErrorState = ExtractMatchingSentences();
			return SearchDocuments();
		}
		
		private bool SearchDocuments()
		{
			foreach (Document document in Documents)
			{
				document.Search(SearchPerimeters);				
			}

			return Documents.Exists(x => x.MatchingSentences.Count != 0);
		}

		private void ExtractSentences(Document document)
		{
			foreach (Sentence sentence in document.Sentences)
			{
				int search1Matches = sentence.Value.Split(
					new string[] { SearchPerimeters[0].Value }, 
					StringSplitOptions.RemoveEmptyEntries).Length;

				if (SearchPerimeters.Count == 1)
				{
					if (search1Matches != 0)
					{
						sentence.AddToMatches(search1Matches);
					}
				}

				else
				{
					int search2Matches = sentence.Value.Split(
						new string[] { SearchPerimeters[1].Value }, 
						StringSplitOptions.RemoveEmptyEntries).Length;

					if (SearchPerimeters[1].SearchType == SearchType.OR)
					{
						if (search1Matches != 0 || search2Matches != 0)
						{
							sentence.AddToMatches(search1Matches + search2Matches);
						}
					}
					else
					{
						if (search1Matches != 0 && search2Matches != 0)
						{
							sentence.AddToMatches(search1Matches + search2Matches);
						}
					}
				}
			}
		}
		
		private void ReorderSearchesByAnd()
		{
			if (SearchPerimeters[1].SearchType == SearchType.AND)
			{
				SearchPerimeters.Insert(0, SearchPerimeters[1]);
				SearchPerimeters.RemoveAt(2);
			}
		}
	}
}