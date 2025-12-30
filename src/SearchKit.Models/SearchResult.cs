using System.Collections.Generic;

namespace SearchKit.Models
{
    public class SearchResult<T>
    {
        public SearchResult(IEnumerable<T> items, int total)
        {
            Total = total;
            Items = items;
        }

        public SearchResult(IEnumerable<T> items, int total, SearchResultMetadata metadata)
        {
            Total = total;
            Items = items;
            Metadata = metadata;
        }
        
        public int Total { get; }
        public IEnumerable<T> Items { get; }
        public SearchResultMetadata Metadata { get; }
    }
}