using System;
using System.Collections.Generic;
using System.Linq;
using Queries.Core.Repositories;
using Queries.Models;

namespace Queries.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customers>, ICustomerRepository
    {
        public CustomerRepository(NorthwindContext context) : base(context)
        {
        }

        public IEnumerable<Customers> GetCustomerByCity(string city)
        {
            return NorthwindContext.Customers.Where(cw => cw.City == city).ToList();
        }

        public NorthwindContext NorthwindContext
        {
            get { return Context as NorthwindContext; }
        }
    }
}
