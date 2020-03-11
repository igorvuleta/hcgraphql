using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;
using Microsoft.EntityFrameworkCore;

namespace hcgraphqlnew.Repository.SuppliersRepository
{
   public class SuppliersRepository : ISuppliersRepository
   {
      private readonly northwindContext _northwindContext;

      public SuppliersRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public async Task<Suppliers> GetSupplierForProduct(int? supplierID) => await _northwindContext.Suppliers.Where(x => x.SupplierId == supplierID).FirstOrDefaultAsync();

      public IQueryable<Suppliers> GetSuppliers () => _northwindContext.Suppliers;
      
   }
}
