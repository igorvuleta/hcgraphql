using hcgraphqlnew.Models;
using hcgraphqlnew.Repository.ProductsRepository;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Types
{
   public class SuppliersType : ObjectType<Suppliers>
   {
      protected override void Configure(IObjectTypeDescriptor<Suppliers> descriptor)
      {
         descriptor.Field(s => s.SupplierId).Type<IntType>();
         descriptor.Field(s => s.Products).Type<ListType<ProductType>>().Resolver(ctx =>

         ctx.Service<IProductsRepository>().GetProductsInSuppliers(ctx.Parent<Suppliers>().SupplierId)

         );
      }
   }
}
