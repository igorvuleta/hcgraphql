using hcgraphqlnew.Models;
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
      }
   }
}
