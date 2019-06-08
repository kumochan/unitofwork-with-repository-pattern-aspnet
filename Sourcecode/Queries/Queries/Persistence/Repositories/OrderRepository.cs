using System;
using System.Collections.Generic;
using System.Linq;
using Queries.Core.Repositories;
using Queries.Models;

namespace Queries.Persistence.Repositories
{
    public class OrderRepository : Repository<Orders>, IOrderRepository
    {

        public OrderRepository(NorthwindContext context) : base(context)
        {
        }

        public IEnumerable<Orders> GetOrdersWithCustomers(int pageIndex, int pageSize, string customerId)
        {
            return NorthwindContext.Orders
                .Where(o => o.CustomerId == customerId)
                .OrderBy(c => c.OrderId)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public IEnumerable<Orders> GetTopOrders(int count)
        {
            return NorthwindContext.Orders.OrderByDescending(c => c.OrderId).Take(count).ToList();
        }

        public NorthwindContext NorthwindContext
        {
            get { return Context as NorthwindContext; }
        }
    }
}
