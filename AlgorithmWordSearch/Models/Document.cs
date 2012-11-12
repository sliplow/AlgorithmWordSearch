using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmWordSearch.Models
{
	public class Document
	{
		public string Path { get; set; }
		public List<ISentence> Sentences { get; set; }
		public List<MatchingSentence> MatchingSentences { get; set; }

		public Document()
		{
			Sentences = new List<ISentence>();
			MatchingSentences = new List<MatchingSentence>();
		}

	}
}