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

			Sort();

			MatchingSentences = new TripleSort(MatchingSentences).Sort();
		}

		private void Sort()
		{
			// No sort if less than two results
			if (MatchingSentences.Count < 2) return;

			int startOfSecoundHalf = Math.Abs(MatchingSentences.Count/2);

			List<Sentence> secondHalf = new List<Sentence>();
			for(int counter = startOfSecoundHalf; counter < MatchingSentences.Count; counter ++)
			{
				secondHalf.Add(MatchingSentences[counter]);
			}

			MatchingSentences.RemoveRange(startOfSecoundHalf, MatchingSentences.Count - startOfSecoundHalf);

			MatchingSentences = MatchingSentences.OrderByDescending(x => x.Importance).ToList();
			
			MatchingSentences.AddRange(secondHalf.OrderByDescending(x => x.Importance));

			MatchingSentences = MatchingSentences.OrderByDescending(x => x.Importance).ToList();
		}
	}
}