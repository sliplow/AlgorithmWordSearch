﻿using System.Collections.Generic;
using System.Linq;
using AlgorithmWordSearch.Serialiser;

namespace AlgorithmWordSearch.Models
{
	public class Document
	{
		public string Path { get; set; }
		public List<Sentence> Sentences { get; set; }
		public List<Sentence> MatchingSentences { get; set; }

		public Document()
		{
			Sentences = new List<Sentence>();
		}


		public void Search(List<SearchPerimeter> SearchPerimeters)
		{
			// This allows the data to be cleared between searches.
			MatchingSentences = new List<Sentence>();							

			if (SearchPerimeters.Count == 1)
			{
				Sentences.ForEach(
					x => new SingleSearcher(
						x, 
						SearchPerimeters[0].Value)
							.Search());
			}
			else if (SearchPerimeters[1].SearchType == SearchType.OR)
			{
				Sentences.ForEach(
					x => new OrSearcher(
						x,
						SearchPerimeters[0].Value,
						SearchPerimeters[1].Value)
							.Search());
			}
			else
			{
				Sentences.ForEach(
					x => new AndSearcher(
						x,
						SearchPerimeters[0].Value,
						SearchPerimeters[1].Value)
							.Search());
			}

			MatchingSentences = MatchingSentences.OrderByDescending(x => x.Importance).ToList();
		}
	}
}