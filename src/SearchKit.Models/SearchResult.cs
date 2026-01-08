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

        public SearchResult(IEnumerable<T> items, int total, string continuationToken)
        {
            Total = total;
            Items = items;
            ContinuationToken = continuationToken;
        }

        public SearchResult(IEnumerable<T> items, int total, string continuationToken, SearchResultMetadata metadata)
        {
            Total = total;
            Items = items;
            ContinuationToken = continuationToken;
            Metadata = metadata;
        }
        
        public int Total { get; }
        public IEnumerable<T> Items { get; }
        public string ContinuationToken { get; }
        public SearchResultMetadata Metadata { get; }

        public bool HasContinuationToken() => !string.IsNullOrWhiteSpace(ContinuationToken);        
    }
}