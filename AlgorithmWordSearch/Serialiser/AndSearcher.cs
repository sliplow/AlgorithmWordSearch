using System;
using AlgorithmWordSearch.Models;

namespace AlgorithmWordSearch.Serialiser
{
	public class AndSearcher : BaseSearcher
	{
		public AndSearcher(
			string search1,
			string search2)
			: base(
				search1,
				search2) 
		{
		}

		public override void Search(Sentence sentence)
		{
			base.Search(sentence);

			if (Search1Matches != 0 && Search2Matches != 0)
			{
				// We use an optional perimeter to get the number of pairs and couples in the search.

				sentence.AddToMatches(
					Search1Matches * Search1.Length + Search2Matches * Search2.Length,
					Math.Min(Search1Matches, Search2Matches) * (Search1.Length + Search2.Length));

				sentence.Importance *= MatchesProximity;

				RoundImportance(sentence);
			}
		}
	}
}