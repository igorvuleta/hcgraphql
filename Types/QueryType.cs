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

         descriptor.Field(t => t.GetSuppliers(default))
           .UseFiltering()
           .UseSorting();

         descriptor.Field(t => t.GetShippers(default))
           .UseFiltering()
           .UseSorting();

         descriptor.Field(t => t.GetEmployees(default))
           .UseFiltering()
           .UseSorting();

         descriptor.Field(t => t.GetTerritories(default))
           .UseFiltering()
           .UseSorting();

         descriptor.Field(t => t.GetRegions(default))
           .UseFiltering()
           .UseSorting();

         descriptor.Field(t => t.GetEmployeeTerritories(default))
           .UseFiltering()
           .UseSorting();
         descriptor.Field(t => t.GetCustomerCustomerDemo(default))
          .UseFiltering()
          .UseSorting();
         descriptor.Field(t => t.GetCustomerDemographics(default))
         .UseFiltering()
         .UseSorting();




      }
   }
}
