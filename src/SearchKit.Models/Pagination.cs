using System;

namespace SearchKit.Models
{
    public class Pagination
    {
        public Pagination(int first, int size)
        {
            if (first < 0) throw new ArgumentOutOfRangeException(nameof(first), $"{First} cannot be negative");
            if (size < 1) throw new ArgumentOutOfRangeException(nameof(size), $"{size} must be greater or equal than one");
            
            First = first;
            Size = size;
        }
        
        public int First { get; }
        public int Size { get; }
    }
}