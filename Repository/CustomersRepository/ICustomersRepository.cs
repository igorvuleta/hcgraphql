using hcgraphqlnew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Repository.CustomersRepository
{
   public interface ICustomersRepository
   {
      IQueryable<Customers> GetCustomers();
      Task<Customers> GetCustomerById(string id);
   }
}
