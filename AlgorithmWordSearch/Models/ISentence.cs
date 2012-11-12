namespace AlgorithmWordSearch.Models
{
	public interface ISentence
	{
		Document Parent { get; set; }
		string Value { get; set; }

		int Position { get; set; }
	}
}