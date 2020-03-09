using hcgraphqlnew.Models;
using hcgraphqlnew.Repository.CustomersRepository;
using hcgraphqlnew.Repository.OrderDetailsRepository;
using hcgraphqlnew.Repository.OrdersRepository;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Types
{
   public class OrdersType : ObjectType<Orders>
   {
      protected override void Configure(IObjectTypeDescriptor<Orders> descriptor)
      {

         descriptor.Field(o => o.OrderId).Type<NonNullType<IdType>>();
         descriptor.Field(o => o.OrderDetails).Type<ListType<OrderDetailsType>>().Resolver(ctx =>

         ctx.Service<IOrderDetailsRepository>().GetOrdersDetailsList(ctx.Parent<Orders>().OrderId));
        
      }
   }
}
