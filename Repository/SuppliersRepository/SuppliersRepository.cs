using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

namespace hcgraphqlnew.Repository.SuppliersRepository
{
   public class SuppliersRepository : ISuppliersRepository
   {
      private readonly northwindContext _northwindContext;

      public SuppliersRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public IQueryable<Suppliers> GetSuppliers () => _northwindContext.Suppliers;
      
   }
}
