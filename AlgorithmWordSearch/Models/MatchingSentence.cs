using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmWordSearch.Models
{
	public class MatchingSentence : ISentence
	{
		public string Value { get; set; }

		public int Importance { get; set; }
		public int Position { get; set; }
	}
}