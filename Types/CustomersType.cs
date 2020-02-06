using hcgraphqlnew.Models;
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
         base.Configure(descriptor);
      }
   }
}
