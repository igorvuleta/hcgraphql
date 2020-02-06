using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

namespace hcgraphqlnew.Repository.RegionRepository
{
   public class RegionRepository : IRegionRepository
   {
      private readonly northwindContext _northwindContext;
      public RegionRepository(northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public IQueryable<Region> GetRegions() => _northwindContext.Region;
   }
}
