using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

namespace hcgraphqlnew.Repository.CustomerDemographicsRepository
{
   public class CustomerDemographicsRepository : ICustomerDemographicsRepository
   {
      private readonly northwindContext _northwindContext;
      public CustomerDemographicsRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public IQueryable<CustomerDemographics> GetCustomerDemographics() => _northwindContext.CustomerDemographics;
    
   }
}
