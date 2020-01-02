using hcgraphqlnew.Models;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Types
{
   public class ProductType : ObjectType<Products>
   {
      protected override void Configure(IObjectTypeDescriptor<Products> descriptor)
      {
         descriptor.Field(t => t.ProductId).Type<NonNullType<IntType>>();
      }
   }
}
