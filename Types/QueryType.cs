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
            .UsePaging<ProductType>();
            
            
        }
    }
}
