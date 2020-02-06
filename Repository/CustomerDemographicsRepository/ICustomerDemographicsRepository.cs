using hcgraphqlnew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Repository.CustomerDemographicsRepository
{
   public interface ICustomerDemographicsRepository
   {
      IQueryable<CustomerDemographics> GetCustomerDemographics();
   }
}
