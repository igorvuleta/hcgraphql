using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;
using Microsoft.EntityFrameworkCore;

namespace hcgraphqlnew.Repository.CategoriesRepository
{
   public class CategoriesRepository : ICategoriesRepository
   {
      private readonly northwindContext _northwindContext;

      public CategoriesRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public IQueryable<Categories> GetCategories()
      {
         return  _northwindContext.Categories.AsQueryable();
      }

      public async Task<Categories>  GetCategory(int? categoryId)
      {
          return await _northwindContext.Categories.Where(c => c.CategoryId == categoryId).FirstOrDefaultAsync();
        
      }
   }
}
