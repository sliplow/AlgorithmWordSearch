namespace AlgorithmWordSearch.Models
{
	public class Sentence : ISentence
	{
		public Document Parent { get; set; }
		public string Value { get; set; }

		public int Importance { get; set; }
		public int Position { get; set; }
		
		public Sentence(Document parent)
		{
			Parent = parent;
		}

		public void AddToMatches(int searchMatches)
		{
			Sentence sentence = this;

			sentence.Importance = searchMatches;

			sentence.Parent.MatchingSentences.Add(sentence);
		}
	}
}