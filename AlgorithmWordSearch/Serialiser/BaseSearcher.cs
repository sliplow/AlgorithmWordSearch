using System.Text.RegularExpressions;
using AlgorithmWordSearch.Models;
using System;

namespace AlgorithmWordSearch.Serialiser
{
	public abstract class BaseSearcher
	{
		protected string Search1 { get; set; }
		protected string Search2 { get; set; }

		protected int Search1Matches { get; set; }
		protected int Search2Matches { get; set; }

		protected int MatchesProximity { get; set; }
		 
		public BaseSearcher(
			string search1,
			string search2)
		{
			// If no matches found we apply no bonus.

			Search1 = search1;
			Search2 = search2;
		}
		
		public BaseSearcher(
			string search1)
		{
			Search1 = search1;
		}

		protected void RoundImportance(Sentence sentence)
		{
			sentence.Importance = Math.Round(sentence.Importance, 2);
		}

		/// <summary>
		/// http://social.msdn.microsoft.com/Forums/en-US/csharplanguage/thread/2be73700-38cd-4098-9852-95b8d1406498
		/// Used the above method instead of my initial idea of split, remove incorrect and then count.
		/// Because of the additional loop involved.
		/// </summary>
		public virtual void Search(Sentence sentence)
		{
			// Reset the proximity of each search
			MatchesProximity = 1;

			// Get all matches for the first search option.
			MatchCollection matches1 = Regex.Matches(sentence.Value, Search1);
			Search1Matches = matches1.Count;
			
			// If there is no second search option return
			if (string.IsNullOrEmpty(Search2)) return;

			// Get all matches for the second search option.
			MatchCollection matches2 = Regex.Matches(sentence.Value, Search2);
			Search2Matches = matches2.Count;



			// Return if there are not matches in both searches.
			if (Search1Matches == 0 || Search2Matches == 0) return;

			// This is the position of the first match in value
			int startIndex = 0;
			if (matches1[0].Index > matches2[0].Index)
			{
				startIndex = matches2[0].Index;
			}
			else
			{
				startIndex = matches1[0].Index;
			}


			// This is the position of the last match in value
			int endIndex = 0;
			if (matches1[matches1.Count - 1].Index > matches2[matches2.Count - 1].Index)
			{
				endIndex = matches2[matches2.Count - 1].Index;
			}
			else
			{
				endIndex = matches1[matches1.Count - 1].Index;
			}

			// Percentage closeness of the first and last match.

			MatchesProximity = 100 - 
			// Because we value close matches we remove the distance percentage of matches from 100%
				(((endIndex - startIndex) - 
					// Remove all matches from each search from the length.
					((Search1Matches - 1) * Search1.Length) - 
					((Search2Matches - 1) * Search2.Length))
				// Get as percentage of all characters in the sentence
				/ sentence.Value.Length);
		}
	}
}