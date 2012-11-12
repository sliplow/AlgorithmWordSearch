using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlgorithmWordSearch.Models;

namespace AlgorithmWordSearch
{
	public class DocumentSearcher
	{
		public List<Document> Documents { get; set; }
		public List<SearchPerimeter> SearchPerimeters { get; set; }
		
		public DocumentSearcher(
			List<Document> inputDocuments,
			List<SearchPerimeter> searchPerimeters)
		{
			Documents = inputDocuments;
			SearchPerimeters = searchPerimeters;
		}

		public bool Search()
		{
			if (SearchPerimeters.Count == 0) return false;
					
			ReorderSearchesByAnd();

			//bool isNotErrorState = ExtractMatchingSentences();
			return ExtractMatchingSentences();
		}
		
		private bool ExtractMatchingSentences()
		{
			bool isNotErrorState = false;
			
			foreach (Document document in Documents)
			{
				for (int count = 0; count < document.Sentences.Count; count++)
				{
					int search1Matches = document.Sentences[count - 1].Value.Split(
						new string[]{SearchPerimeters[0].Value}, StringSplitOptions.RemoveEmptyEntries).Length;
					

					switch (SearchPerimeters.Count)
					{
						case (1):
						{
							if (search1Matches != 0)
							{								 
								MatchingSentence sentence = AddSentenceToMatchingSentences(document, count);

								sentence.Importance = search1Matches;

								isNotErrorState = true;
							}
						}
						break;

						//case (2):
						default:
						{
							int search2Matches = document.Sentences[count - 1].Value.Split(
								new string[] { SearchPerimeters[0].Value }, StringSplitOptions.RemoveEmptyEntries).Length;

							if (SearchPerimeters[1].SearchType == SearchType.OR)
							{
								if (search1Matches != 0 || search2Matches != 0)
								{
									MatchingSentence sentence = AddSentenceToMatchingSentences(document, count);

									sentence.Importance = search1Matches;
									
									isNotErrorState = true;
								}
							}
							else
							{
								if (search1Matches != 0 && search2Matches != 0)
								{
									MatchingSentence sentence = AddSentenceToMatchingSentences(document, count);

									sentence.Importance = search1Matches;
									
									isNotErrorState = true;
								}
							}
						}
							break;
					}
				}

				document.MatchingSentences.OrderBy(x => x.Importance);
			}
			return isNotErrorState;
		}

		private MatchingSentence AddSentenceToMatchingSentences(Document document, int count)
		{
			MatchingSentence matchingSentence = (MatchingSentence)document.Sentences[count];
			matchingSentence.Position = count;
			
			document.MatchingSentences.Add(matchingSentence);

			return matchingSentence;
		}

		private void ReorderSearchesByAnd()
		{
			if (SearchPerimeters[1].SearchType == SearchType.AND)
			{
				SearchPerimeters.Insert(0, SearchPerimeters[1]);
				SearchPerimeters.RemoveAt(2);
			}
		}
	}
}