using AlgorithmWordSearch.Models;
using System;

namespace AlgorithmWordSearch.Serialiser
{
	public class AndSearcher : BaseSearcher
	{
		public AndSearcher(
			Sentence sentence,
			string search1,
			string search2)
			: base(
				sentence,
				search1,
				search2) 
		{
		}

		public override void Search()
		{
			base.Search();

			if (Search1Matches != 0 && Search2Matches != 0)
			{
				// We use an optional perimeter to get the number of pairs and couples in the search.

				Sentence.AddToMatches(
					Search1Matches * Search1.Length + Search2Matches * Search2.Length,
					Math.Min(Search1Matches, Search2Matches) * (Search1.Length + Search2.Length));

				Sentence.Importance *= MatchesProximity;

				RoundImportance();
			}
		}
	}
}