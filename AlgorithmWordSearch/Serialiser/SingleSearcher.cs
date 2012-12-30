using AlgorithmWordSearch.Models;

namespace AlgorithmWordSearch.Serialiser
{
	public class SingleSearcher : BaseSearcher
	{		 
		public SingleSearcher(string search1)
			: base(search1) 
		{
		}

		public override void Search(Sentence sentence)			
		{
			base.Search(sentence);

			if (Search1Matches != 0)
			{
				sentence.AddToMatches(Search1Matches * Search1.Length);

				RoundImportance(sentence);
			}
		}
	}
}