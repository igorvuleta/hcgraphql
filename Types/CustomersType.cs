using hcgraphqlnew.Models;
using hcgraphqlnew.Repository.OrdersRepository;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Types
{
   public class CustomersType : ObjectType<Customers>
   {
      protected override void Configure(IObjectTypeDescriptor<Customers> descriptor)
      {
         descriptor.Field(c => c.CustomerId).Type<NonNullType<IdType>>();
         descriptor.Field(c => c.Orders).Type<ListType<OrdersType>>().Resolver(ctx =>

         ctx.Service<IOrdersRepository>().GetOrdersListForCustomer(ctx.Parent<Customers>().CustomerId));
      }
   }
}
