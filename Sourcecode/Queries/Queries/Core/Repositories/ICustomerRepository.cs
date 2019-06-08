using System;
using System.Collections.Generic;
using Queries.Models;

namespace Queries.Core.Repositories
{
    public interface ICustomerRepository : IRepository<Customers>
    {
        IEnumerable<Customers> GetCustomerByCity(string city);
    }
}
