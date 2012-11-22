namespace AlgorithmWordSearch.Models
{
	public class Sentence
	{
		public Document Parent { get; set; }
		public string Value { get; set; }

		public double Importance { get; set; }
		public int Position { get; set; }
		
		public Sentence(Document parent)
		{
			Parent = parent;
		}

		public void AddToMatches(double searchMatches, double containsBoth = 0)
		{
			Sentence sentence = this;

			sentence.Importance = (double)searchMatches / (double)Value.Length * (double)100;

			if (containsBoth != 0)
			{
				// If the sentence has both values then we increase the importance by a bonus ammount.

				sentence.Importance += (double)containsBoth / (double)Value.Length * (double)100;
			}

			sentence.Parent.MatchingSentences.Add(sentence);
		}
	}
}