namespace SearchKit.Models
{
    public class SearchResultMetadata
    {
        public SearchResultMetadata(long elapsedMilliseconds)
        {
            ElapsedMilliseconds = elapsedMilliseconds;
        }

        public SearchResultMetadata(long elapsedMilliseconds, double cost)
        {
            ElapsedMilliseconds = elapsedMilliseconds;
            Cost = cost;
        }
        
        public long ElapsedMilliseconds { get; }
        public double Cost { get; }
    }
}
