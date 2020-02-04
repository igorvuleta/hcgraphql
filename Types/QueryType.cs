using HotChocolate.Types;
using HotChocolate.Types.Relay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Types
{
    public class QueryType : ObjectType<Query>
    {

        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
         descriptor.Field(t => t.GetProducts(default))
               .Type<ListType<ProductType>>()
               .UseFiltering()
               .UseSorting()
               .Argument("CategoryId", a => a.Type<IntType>());


         descriptor.Field(t => t.GetCategories(default))
             .UseFiltering()
             .UseSorting();

         descriptor.Field(t => t.GetCustomers(default))
            .UseFiltering()
            .UseSorting();

         descriptor.Field(t => t.GetOrders(default))
            .UseFiltering()
            .UseSorting();
         descriptor.Field(t => t.GetOrderDetails(default))
            .UseFiltering()
            .UseSorting();

      }
    }
}
