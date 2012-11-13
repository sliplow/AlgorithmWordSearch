using System.Collections.Generic;
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
		
		private void ReorderSearchesByAnd()
		{
			if (SearchPerimeters.Count == 1 ||
				SearchPerimeters[1].SearchType == SearchType.OR) return;
			
			SearchPerimeters.Insert(0, SearchPerimeters[1]);
			SearchPerimeters.RemoveAt(2);
			
		}
	}
}