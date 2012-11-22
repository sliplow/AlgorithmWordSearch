using System.Collections.Generic;
using System.Linq;

namespace AlgorithmWordSearch.Models
{
	public class DocumentList : List<Document>
	{
		public Document GetHighestPriority()
		{
			return this.First(x => x.MatchingSentences.Count == this.Max(y => y.MatchingSentences.Count));
		}
	}
}