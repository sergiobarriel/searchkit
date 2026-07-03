using System;

namespace SearchKit.Models
{
    public class CursorPagination
    {
        public CursorPagination(string continuationToken, int size)
        {
            if (size < 1) throw new ArgumentOutOfRangeException(nameof(size), $"{size} must be greater or equal than one");
            
            ContinuationToken = string.IsNullOrEmpty(continuationToken) 
                ? null 
                : continuationToken;
                
            Size = size;
        }
        
        public string ContinuationToken { get; }
        public int Size { get; }

        public bool IsValid() => Size >= 1;
    }
}
