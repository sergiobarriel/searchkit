namespace SearchKit.Models
{
    public class SearchResultMetadata
    {
        public SearchResultMetadata(long elapsedMilliseconds)
        {
            ElapsedMilliseconds = elapsedMilliseconds;
        }
        
        public long ElapsedMilliseconds { get; set; }
    }
}