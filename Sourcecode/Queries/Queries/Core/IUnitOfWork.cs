using System;
using Queries.Core.Repositories;

namespace Queries.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IOrderRepository Orders { get; }
        ICustomerRepository Customers { get; }
        IOrderDetailRepository OrderDetails { get; }
        int Complete();
    }
}
