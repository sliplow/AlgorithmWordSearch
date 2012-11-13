using System.Text.RegularExpressions;
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

		/// <summary>
		/// http://social.msdn.microsoft.com/Forums/en-US/csharplanguage/thread/2be73700-38cd-4098-9852-95b8d1406498
		/// Used the above method instead of my initial idea of split, remove incorrect and then count.
		/// Because of the additional loop involved.
		/// </summary>
		public virtual void Search()
		{
			Search1Matches = Regex.Matches(Sentence.Value, Search1).Count;
			
			if (string.IsNullOrEmpty(Search2)) return;

			Search2Matches = Regex.Matches(Sentence.Value, Search2).Count; 
		}
	}
}