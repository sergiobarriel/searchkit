using System;

namespace SearchKit.Models
{
    public abstract class SearchParameters
    {
        public Pagination Pagination { get; }
        public Order Order { get; }

        protected SearchParameters(Pagination pagination, Order order)
        {
            Pagination = pagination;            
            Order = order;
        }
    }
}