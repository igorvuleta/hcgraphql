using hcgraphqlnew.Models;
using hcgraphqlnew.Repository.CategoriesRepository;
using hcgraphqlnew.Repository.ProductsRepository;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace hcgraphqlnew
{
    public class Query
    {
        
      public IQueryable<Products> GetProducts([Service]IProductsRepository repository)
      {
         return repository.GetProducts();
      }
      public IQueryable<Categories> GetCategories([Service]ICategoriesRepository repository)
      {
         return repository.GetCategories();
      }
   }

 
}
