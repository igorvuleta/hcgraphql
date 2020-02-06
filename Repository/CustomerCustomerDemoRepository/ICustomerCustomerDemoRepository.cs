using hcgraphqlnew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Repository.CustomerCustomerDemoRepository
{
   public interface ICustomerCustomerDemoRepository
   {
      IQueryable<CustomerCustomerDemo> GetCustomerCustomerDemos();
   }
}
