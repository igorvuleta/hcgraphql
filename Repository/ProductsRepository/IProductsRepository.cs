using hcgraphqlnew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Repository.ProductsRepository
{
   public interface IProductsRepository
   {
       IQueryable<Products> GetProducts();
      Task<IEnumerable<Products>> GetProductsList(int? id);



   }
}
