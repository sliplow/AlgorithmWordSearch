using System;
using AlgorithmWordSearch.Models;

namespace AlgorithmWordSearch.Serialiser
{
	public abstract class BaseSearcher
	{
		protected Sentence Sentence { get; set; }

		protected string Search1 { get; set; }
		protected string Search2 { get; set; }

		protected int Search1Matches { get; set; }
		protected int Search2Matches { get; set; }
		 
		public BaseSearcher(
			Sentence sentence,
			string search1,
			string search2)
		{
			Sentence = sentence;
			Search1 = search1;
			Search2 = search2;
		}
		
		public BaseSearcher(
			Sentence sentence,
			string search1)
		{
			Sentence = sentence;
			Search1 = search1;
		}

		public virtual void Search()
		{
			Search1Matches = Sentence.Value.Split(
				new string[] { Search1 },
				StringSplitOptions.RemoveEmptyEntries).Length;
			
			if (string.IsNullOrEmpty(Search2)) return;
				
			Search2Matches = Sentence.Value.Split(
				new string[] { Search2 },
				StringSplitOptions.RemoveEmptyEntries).Length; 
		}
	}
}