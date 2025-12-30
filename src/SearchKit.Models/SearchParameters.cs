using System;

namespace SearchKit.Models
{
    public abstract class SearchParameters
    {
        public Pagination Pagination { get; private set; }
        public Order Order { get; private set; }

        protected SearchParameters(Pagination pagination, Order order)
        {
            Pagination = pagination ?? 
                         throw new ArgumentNullException(nameof(pagination));
            
            Order = order ?? 
                    throw new ArgumentNullException(nameof(order));
        }
    }
}