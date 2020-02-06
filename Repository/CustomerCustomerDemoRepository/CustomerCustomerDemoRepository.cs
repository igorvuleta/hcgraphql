using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

namespace hcgraphqlnew.Repository.CustomerCustomerDemoRepository
{
   public class CustomerCustomerDemoRepository : ICustomerCustomerDemoRepository
   {
      private readonly northwindContext _northwindContext;
      public CustomerCustomerDemoRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public IQueryable<CustomerCustomerDemo> GetCustomerCustomerDemos() => _northwindContext.CustomerCustomerDemo;
   }
}
