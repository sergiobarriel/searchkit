using System;
using System.Collections.Generic;
using System.Linq;

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

        public Order(string property, string direction)
        {
            if (string.IsNullOrWhiteSpace(property)) throw new ArgumentException("Ordering property cannot be null or empty", nameof(property));
            if (string.IsNullOrWhiteSpace(direction)) throw new ArgumentException("Direction property cannot be null or empty", nameof(direction));

            Property = property;
            Direction = Parse(direction); ;
        }

        public string Property { get; }
        public OrderDirection Direction { get; }

        public bool IsAscending() => Direction == OrderDirection.Ascending;
        public bool IsDescending() => Direction == OrderDirection.Descending;
        public bool IsValid() => !string.IsNullOrWhiteSpace(Property);

        private static OrderDirection Parse(string direction)
        {
            if (Ascending.Contains(direction))
            {
                return OrderDirection.Ascending;
            }

            if (Descending.Contains(direction))
            {
                return OrderDirection.Descending;
            }

            throw new ArgumentException($"Invalid {nameof(direction)} value", nameof(direction));
        }

        private static readonly HashSet<string> Ascending = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "a", "asc", "ascending", "up", "oldest", "0"
        };

        private static readonly HashSet<string> Descending = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "d", "desc", "descending", "down", "newest", "1"
        };
    }
}