using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmWordSearch.Models
{
	public class Sentence : ISentence
	{
		public Document Parent { get; set; }
		public string Value { get; set; }

		public int Importance { get; set; }
		public int Position { get; set; }
		
		public Sentence(Document parent)
		{
			Parent = parent;
		}

		public void AddToMatches(int search1Matches)
		{
			Sentence sentence = this;

			sentence.Importance = search1Matches;

			sentence.Parent.MatchingSentences.Add(sentence);
		}
	}
}