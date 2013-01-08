using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmWordSearch.Serialiser;

namespace AlgorithmWordSearch.Models
{
	public class Document
	{
		public string Path { get; set; }
		public List<Sentence> Sentences { get; set; }
		public List<Sentence> MatchingSentences { get; set; }

		public double Importance
		{
			get
			{
				return MatchingSentences.Sum(x => x.Importance);
			}
		}

		public Document()
		{
			Sentences = new List<Sentence>();
		}


		public void Search(BaseSearcher searcher)
		{
			// This allows the data to be cleared between searches.
			MatchingSentences = new List<Sentence>();							

			Sentences.ForEach(x => searcher.Search(x));
			
			MatchingSentences = new TripleSort(MatchingSentences).Sort();
		}
	}
}