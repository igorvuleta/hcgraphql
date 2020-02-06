using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

namespace hcgraphqlnew.Repository.EmployeeTerritoriesRepository
{
   public class EmployeeTerritoriesRepository : IEmployeeTerritoriesRepository
   {
      private readonly northwindContext _northwindContext;

      public EmployeeTerritoriesRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public IQueryable<EmployeeTerritories> GetEmployeeTerritories() => _northwindContext.EmployeeTerritories;
   }
}
