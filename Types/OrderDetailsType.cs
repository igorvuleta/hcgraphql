using hcgraphqlnew.Models;
using hcgraphqlnew.Repository.OrdersRepository;
using hcgraphqlnew.Repository.ProductsRepository;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Types
{
   public class OrderDetailsType : ObjectType<OrderDetails>
   {
      protected override void Configure(IObjectTypeDescriptor<OrderDetails> descriptor)
      {
         descriptor.Field(o => o.OrderId).Type<NonNullType<IntType>>();
         descriptor.Field(o => o.ProductId).Type<NonNullType<IntType>>();
         descriptor.Field(o => o.Order).Type<OrdersType>().Resolver(ctx =>

         ctx.Service<IOrdersRepository>().GetOrder(ctx.Parent<OrderDetails>().OrderId));
         descriptor.Field(o => o.Product).Type<ProductType>().Resolver(ctx =>

         ctx.Service<IProductsRepository>().GetProductInOrders(ctx.Parent<OrderDetails>().ProductId));

      }
   }
}
