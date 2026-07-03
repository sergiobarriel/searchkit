using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchKit.Models
{
    public abstract class SearchParameters
    {
        public OffsetPagination OffsetPagination { get; }
        public CursorPagination CursorPagination { get; }

        public IEnumerable<Order> Orders { get; }

        protected SearchParameters(OffsetPagination offsetPagination, Order order)
        {
            OffsetPagination = offsetPagination;            
            Orders = new List<Order> { order };
        }

        protected SearchParameters(OffsetPagination offsetPagination, IEnumerable<Order> orders)
        {
            OffsetPagination = offsetPagination;            
            Orders = orders;
        }

        protected SearchParameters(CursorPagination cursorPagination, Order order)
        {
            CursorPagination = cursorPagination;
            Orders = new List<Order> { order };
        }

        protected SearchParameters(CursorPagination cursorPagination, IEnumerable<Order> orders)
        {
            CursorPagination = cursorPagination;
            Orders = orders;
        }

        public bool HasOffsetPagination() => OffsetPagination != null;
        public bool HasNoOffsetPagination() => OffsetPagination == null;
        public bool HasCursorPagination() => CursorPagination != null;
        public bool HasNoCursorPagination() => CursorPagination == null;

        public bool HasPagination() => HasOffsetPagination() || HasCursorPagination();

        public bool HasOrders() => Orders != null && Orders.Any();
        public bool HasMultipleOrders() => Orders != null && Orders.Count() > 1;
        public bool HasSingleOrder() => Orders != null && Orders.Count() == 1;
    }
}