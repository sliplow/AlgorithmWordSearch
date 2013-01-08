﻿using System;
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
					return TripleListSort(OriginalSentences);
				}
			}
		}

		/// <summary>
		/// This sorts two items in a list.
		/// </summary>
		/// <param name="tempList"></param>
		/// <param name="firstNum"></param>
		/// <param name="secondNum"></param>
		/// <returns>a new list with the items ordered by highest value first</returns>
		private List<Sentence> Sort(List<Sentence> tempList, int firstNum, int secondNum)
		{
			// Check if one item is larger than the other.

			if (tempList[secondNum].Importance > tempList[firstNum].Importance)
			{
				// returns a new list with the items ordered by highest value first.

				return new List<Sentence>() { tempList[secondNum], tempList[firstNum] };
			}

			return new List<Sentence>() { tempList[firstNum], tempList[secondNum] };
		}

		private List<Sentence> TripleListSort(List<Sentence> listToBeSplit)
		{
			// This variable is used to count how many items will be in each sublist.

			double sortEveryKey = listToBeSplit.Count / (double) 3;
			List<Sentence> sortedItems = new List<Sentence>();

			// Break Sentences up into three groups.
			// This is recursive so this will continue to divide the list into smaller lists then merge them together.

			List<Sentence> firstGroup = SortInternalList(listToBeSplit, 0, sortEveryKey);
			List<Sentence> thirdGroup = SortInternalList(listToBeSplit, sortEveryKey * 2, sortEveryKey * 3);
			sortedItems.AddRange(SortInternalList(listToBeSplit, sortEveryKey, sortEveryKey * 2));

			// Merge the other lists into the sorted list.

			MergeList(sortedItems, thirdGroup);
			MergeList(sortedItems, firstGroup);

			return sortedItems;
		}

		private List<Sentence> SortInternalList(List<Sentence> tempList, double startKey, double endKey)
		{
			List<Sentence> smallerTempList = new List<Sentence>();
			
			// This is to stop Math.Abs rounding down and causing duplicate entries in the lists.

			if ((startKey - (int)startKey) > 0) startKey++;

			for (double counter = Math.Abs(startKey); counter < endKey; counter++)
			{
				smallerTempList.Add(tempList[(int)counter]);
			}

			switch (smallerTempList.Count)
			{
				case 0:
				{
					return smallerTempList;
				}

				case 1:
				{
					return smallerTempList;
				}

				case 2:
				{
					return Sort(smallerTempList, 0, 1);
				}

				default:
				{
					return TripleListSort(smallerTempList);
				}
			}
		}

		/// <summary>
		/// Merge and sort another list into the first list.
		/// </summary>
		/// <param name="sortedItems"></param>
		/// <param name="mergingList"></param>
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