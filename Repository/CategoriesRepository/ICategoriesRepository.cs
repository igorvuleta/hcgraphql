﻿using hcgraphqlnew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Repository.CategoriesRepository
{
   public interface ICategoriesRepository
   {
      IQueryable<Categories> GetCategories();
      Categories GetCategory(int? categoryId);
   }
}
