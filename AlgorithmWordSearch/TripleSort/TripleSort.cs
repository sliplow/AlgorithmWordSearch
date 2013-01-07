using System.Collections.Generic;
using AlgorithmWordSearch.Models;
using System;

namespace AlgorithmWordSearch.TripeSort
{
	public class TripleSort
	{
		private List<Sentence> originalSentences { get; set; }

		public TripleSort(List<Sentence> sentences)
		{
			originalSentences = sentences;
		}

		public List<Sentence> Sort()
		{
			switch (originalSentences.Count)
			{	
				case 0:
				{
					return originalSentences;
				}

				case 1:
				{
					return originalSentences;
				}

				case 2:
				{
					Sort(0, 1);
				
					return originalSentences;
				}

				default:
				{
					int sortEvery = Math.Abs(originalSentences.Count/ 3);
					
					//for(sortEvery )

					return originalSentences;
				}
			}
		}



		private void Sort(int start, int end)
		{
			if (originalSentences[start].Importance < originalSentences[end].Importance)
			{
				Sentence sentence = originalSentences[end];

				originalSentences.RemoveAt(end);
				originalSentences.Insert(start, sentence);
			}
		}
	}
}