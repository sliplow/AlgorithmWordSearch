using System;
using System.Collections.Generic;
using AlgorithmWordSearch.Models;

namespace AlgorithmWordSearch
{
	public class TripleSort
	{
		private List<Sentence> OriginalSentences { get; set; }

		public TripleSort(List<Sentence> sentences)
		{
			OriginalSentences = sentences;
		}

		public List<Sentence> Sort()
		{
			switch (OriginalSentences.Count)
			{	
				case 0:
				{
					return OriginalSentences;
				}

				case 1:
				{
					return OriginalSentences;
				}

				case 2:
				{			
					return Sort(OriginalSentences, 0, 1);
				}

				default:
				{

					//List<Sentence> firstHalf = new List<Sentence>();
					//List<Sentence> secondHalf = new List<Sentence>();
					//List<Sentence> thirdHalf = new List<Sentence>();

					//for (int counter = sortEvery; counter < sortEvery*2; counter++)
					//{
					//    secondHalf.Add(originalSentences[counter]);
					//}
					//for (int counter = sortEvery*3; counter < sortEvery * 3; counter++)
					//{
					//    thirdHalf.Add(originalSentences)
					//}

					return TripleListSort(OriginalSentences);
				}
			}
		}

		private List<Sentence> TripleListSort(List<Sentence> listToBeSplit)
		{
			double sortEveryKey = listToBeSplit.Count / (double) 3;
			List<Sentence> sortedItems = new List<Sentence>();

			List<Sentence> firstGroup = SortList(listToBeSplit, 0, sortEveryKey);
			List<Sentence> thirdGroup = SortList(listToBeSplit, sortEveryKey * 2, sortEveryKey * 3);
			sortedItems.AddRange(SortList(listToBeSplit, sortEveryKey, sortEveryKey * 2));

			MergeList(sortedItems, thirdGroup);
			MergeList(sortedItems, firstGroup);

			return sortedItems;
		}

		private List<Sentence> SortList(List<Sentence> tempList, double startKey, double endKey)
		{
			List<Sentence> smallerTempList = new List<Sentence>();
			
			if ((startKey - (int)startKey) > 0) startKey++;

			 //(trip.IsRaps ? "RAPS" : "AFF")

			for (double counter = Math.Abs(startKey); counter < endKey; counter++)
			{
				smallerTempList.Add(tempList[(int)counter]);
			}

			switch (tempList.Count)
			{
				case 0:
				{
					return smallerTempList;
				}

				case 1:
				{
					return smallerTempList;
				}

				default:
				{
					return TripleListSort(smallerTempList);
				}
			}
		}

		private List<Sentence> Sort(List<Sentence> tempList, int firstNum, int secondNum)
		{
			if (tempList[secondNum].Importance > tempList[firstNum].Importance)
			{
				return new List<Sentence>() { tempList[secondNum], tempList[firstNum] };
			}

			return new List<Sentence>() { tempList[firstNum], tempList[secondNum] };
		}

		private void MergeList(List<Sentence> sortedItems, List<Sentence> mergingList)
		{
			foreach(Sentence sentence in mergingList)
			{
				int counter = sortedItems.Count - 1;
				
				while(counter >= 0)
				{
					if (sortedItems[counter].Importance > sentence.Importance)
					{
						sortedItems.Insert(counter + 1, sentence);

						break;
					}

					counter --;
				}

				if (counter == -1)
				{
					sortedItems.Insert(0, sentence);
				}
			}
		}
	}
}