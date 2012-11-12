namespace AlgorithmWordSearch.Models
{
	public class MatchingSentence : ISentence
	{
		public Document Parent { get; set; }
		public string Value { get; set; }

		public int Importance { get; set; }
		public int Position { get; set; }

		public MatchingSentence(Document parent)
		{
			Parent = parent;
		}
	}
}