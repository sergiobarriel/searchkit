namespace SearchKit.Models
{
    public class SearchResultMetadata
    {

        public SearchResultMetadata(long? elapsedMilliseconds = null, double? cost = null)
        {
            ElapsedMilliseconds = elapsedMilliseconds ?? 0;
            Cost = cost ?? 0;
        }
        
        public long ElapsedMilliseconds { get; }
        public double Cost { get; }
    }
}
