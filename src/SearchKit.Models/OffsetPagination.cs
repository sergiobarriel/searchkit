using System;

namespace SearchKit.Models
{
    public class OffsetPagination
    {
        public OffsetPagination(int first, int size)
        {
            if (first < 1) throw new ArgumentOutOfRangeException(nameof(first), $"{first} cannot be less than one");
            if (size < 1) throw new ArgumentOutOfRangeException(nameof(size), $"{size} must be greater or equal than one");
            
            First = first;
            Size = size;
        }
        
        public int First { get; }
        public int Size { get; }

        public bool IsValid() => First >= 1 && Size >= 1;
    }
}
