using hcgraphqlnew.Models;
using hcgraphqlnew.Repository.CategoriesRepository;
using hcgraphqlnew.Repository.ProductsRepository;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Types
{
   public class CategoriesType : ObjectType<Categories>
   {
      protected override void Configure(IObjectTypeDescriptor<Categories> descriptor)
      {
         descriptor.Field(a => a.CategoryId).Type<NonNullType<IdType>>();
         descriptor.Field(a => a.CategoryName).Type<StringType>();
        
      }
   }
}
