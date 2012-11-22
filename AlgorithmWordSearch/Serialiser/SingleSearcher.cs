using AlgorithmWordSearch.Models;

namespace AlgorithmWordSearch.Serialiser
{
	public class SingleSearcher : BaseSearcher
	{		 
		public SingleSearcher(
			Sentence sentence,
			string search1)
			: base(
				sentence,
				search1) 
		{
		}

		public override void Search()			
		{
			base.Search();

			if (Search1Matches != 0)
			{
				Sentence.AddToMatches(Search1Matches * Search1.Length);

				RoundImportance();
			}
		}
	}
}