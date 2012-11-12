namespace AlgorithmWordSearch.Models
{
	public class SearchPerimeter
	{
		public SearchType SearchType { get; set; }
		public string Value { get; set; }

		public SearchPerimeter(SearchType searchType, string value)
		{
			SearchType = searchType;
			Value = value;
		}
	}
}