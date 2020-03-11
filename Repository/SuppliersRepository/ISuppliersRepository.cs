using hcgraphqlnew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Repository.SuppliersRepository
{
   public interface ISuppliersRepository
   {
      IQueryable<Suppliers> GetSuppliers();
      Task<Suppliers> GetSupplierForProduct(int? supplierID);
   }
}
