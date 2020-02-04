using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

namespace hcgraphqlnew.Repository.CustomersRepository
{
   public class CustomersRepository : ICustomersRepository
   {
      private readonly northwindContext _northwindContext;
      public CustomersRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public IQueryable<Customers> GetCustomers() => _northwindContext.Customers;
   }
}
