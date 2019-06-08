using System;
using System.Collections.Generic;
using Queries.Models;

namespace Queries.Core.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetails>
    {
        IEnumerable<OrderDetails> GetByOrderId(int orderId);
    }
}
