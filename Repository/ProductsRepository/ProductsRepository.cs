using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;
using Microsoft.EntityFrameworkCore;

namespace hcgraphqlnew.Repository.ProductsRepository
{
   public class ProductsRepository : IProductsRepository
   {
      private readonly northwindContext _northwindContext;

      public ProductsRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }


      public IQueryable<Products> GetProducts()
      {
         return _northwindContext.Products.AsQueryable();
      }

      public async Task<IEnumerable<Products>> GetProductsList(int? id)
      {
         return await _northwindContext.Products.Where(p => p.CategoryId == id).ToListAsync();
      }
   }
}
