using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

namespace hcgraphqlnew.Repository.EmployeesRepository
{
   public class EmployeesRepository : IEmployeesRepository
   {
      private readonly northwindContext _northwindContext;

      public EmployeesRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public IQueryable<Employees> GetEmployees() => _northwindContext.Employees;
   }
}
