using AlgorithmWordSearch.Models;

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
				Sentence.AddToMatches(Search1Matches + Search2Matches);
			}
		}
	}
}