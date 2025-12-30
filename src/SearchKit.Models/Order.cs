using System;

namespace SearchKit.Models
{
    public class Order
    {
        public Order(string property, OrderDirection direction)
        {
            if (string.IsNullOrWhiteSpace(property)) throw new ArgumentException("Ordering property cannot be null or empty", nameof(property));
            
            Property = property;
            Direction = direction;
        }
        
        public string Property { get; }
        public OrderDirection Direction { get; }
        
        public bool IsAscending => Direction == OrderDirection.Ascending;
        public bool IsDescending => Direction == OrderDirection.Descending;
    }
}