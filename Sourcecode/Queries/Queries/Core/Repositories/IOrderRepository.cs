using System;
using System.Collections.Generic;
using Queries.Models;

namespace Queries.Core.Repositories
{
    public interface IOrderRepository : IRepository<Orders>
    {
        IEnumerable<Orders> GetTopOrders(int count);
        IEnumerable<Orders> GetOrdersWithCustomers(int pageIndex, int pageSize, string customerId);
    }
}
