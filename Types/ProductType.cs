using GreenDonut;
using hcgraphqlnew.Models;
using hcgraphqlnew.Repository.CategoriesRepository;
using hcgraphqlnew.Repository.OrderDetailsRepository;
using hcgraphqlnew.Repository.ProductsRepository;
using HotChocolate.Resolvers;
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
         descriptor.Field(t => t.Category).Type<CategoriesType>().Resolver(context =>


               context.Service<ICategoriesRepository>().GetCategory(context.Parent<Products>().CategoryId));


         descriptor.Field(t => t.OrderDetails).Type<ListType<OrderDetailsType>>().Resolver(ctx =>

            ctx.Service<IOrderDetailsRepository>().GetOrdersDetailsList(ctx.Parent<Products>().ProductId));

        

      }
      
   }
}
