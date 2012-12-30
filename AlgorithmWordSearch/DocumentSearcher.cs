using System.Collections.Generic;
using AlgorithmWordSearch.Models;
using AlgorithmWordSearch.Serialiser;

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
			BaseSearcher searcher = GetSearchClass();

			foreach (Document document in Documents)
			{
				document.Search(searcher);				
			}

			return Documents.Exists(x => x.MatchingSentences.Count != 0);
		}

		private BaseSearcher GetSearchClass()
		{
			if (SearchPerimeters.Count == 1)
			{
				return new SingleSearcher(
				   SearchPerimeters[0].Value);
			}
			else if (SearchPerimeters[1].SearchType == SearchType.OR)
			{
				return new OrSearcher(
					SearchPerimeters[0].Value,
					SearchPerimeters[1].Value);
			}

			return new AndSearcher(
				SearchPerimeters[0].Value,
				SearchPerimeters[1].Value);
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