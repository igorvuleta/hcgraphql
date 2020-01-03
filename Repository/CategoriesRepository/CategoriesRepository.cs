using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

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
         return _northwindContext.Categories;
      }

      public Categories GetCategory(int? categoryId)
      {
         return  _northwindContext.Categories.Where(c => c.CategoryId == categoryId).FirstOrDefault();
      }
   }
}
