using System;
using System.Collections.Generic;
using System.Linq;
using Queries.Core.Repositories;
using Queries.Models;

namespace Queries.Persistence.Repositories
{
    public class OrderDetailRepository : Repository<OrderDetails>, IOrderDetailRepository
    {
        public OrderDetailRepository(NorthwindContext context) : base(context)
        {
        }

        public NorthwindContext NorthwindContext
        {
            get { return Context as NorthwindContext; }
        }

        public IEnumerable<OrderDetails> GetByOrderId(int orderId)
        {
            return NorthwindContext.OrderDetails.Where(x => x.OrderId == orderId).ToList();
        }
    }
}
