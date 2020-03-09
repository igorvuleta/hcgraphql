using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;
using Microsoft.EntityFrameworkCore;

namespace hcgraphqlnew.Repository.CustomersRepository
{
   public class CustomersRepository : ICustomersRepository
   {
      private readonly northwindContext _northwindContext;
      public CustomersRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public async Task<Customers> GetCustomerById(string id) => await _northwindContext.Customers.Where(x => x.CustomerId == id).FirstOrDefaultAsync();

      public IQueryable<Customers> GetCustomers() => _northwindContext.Customers;

      
   }
}
