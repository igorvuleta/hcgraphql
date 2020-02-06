using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

namespace hcgraphqlnew.Repository.ShippersRepository
{
   public class ShippersRepository : IShippersRepository
   {
      private readonly northwindContext _northwindContext;

      public ShippersRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public IQueryable<Shippers> GetShippers() => _northwindContext.Shippers;
      
   }
}
