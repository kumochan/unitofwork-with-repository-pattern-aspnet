using System;
using Queries.Core;
using Queries.Core.Repositories;
using Queries.Models;
using Queries.Persistence.Repositories;

namespace Queries.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NorthwindContext _context;

        public UnitOfWork(NorthwindContext context)
        {
            _context = context;
            Orders = new OrderRepository(_context);
            Customers = new CustomerRepository(_context);
            OrderDetails = new OrderDetailRepository(_context);
        }

        public IOrderRepository Orders { get; set; }

        public ICustomerRepository Customers { get; set; }

        public IOrderDetailRepository OrderDetails { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
