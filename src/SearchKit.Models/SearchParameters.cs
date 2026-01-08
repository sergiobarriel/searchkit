using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchKit.Models
{
    public abstract class SearchParameters
    {
        public Pagination Pagination { get; }

        public IEnumerable<Order> Orders { get; }

        protected SearchParameters(Pagination pagination, Order order)
        {
            Pagination = pagination;            
            Orders = new List<Order> { order };
        }

         protected SearchParameters(Pagination pagination, IEnumerable<Order> orders)
        {
            Pagination = pagination;            
            Orders = orders;
        }

        [Obsolete("Use Orders property instead")]
        public Order Order => Orders?.FirstOrDefault();

        public bool HasPagination() => Pagination != null;
        public bool HasNoPagination() => Pagination == null;
        public bool HasOrders() => Orders != null && Orders.Any();
        public bool HasMultipleOrders() => Orders != null && Orders.Count() > 1;
        public bool HasSingleOrder() => Orders != null && Orders.Count() == 1;
    }
}