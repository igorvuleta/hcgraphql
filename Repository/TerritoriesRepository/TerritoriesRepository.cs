using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

namespace hcgraphqlnew.Repository.TerritoriesRepository
{
   public class TerritoriesRepository : ITerritoriesRepository
   {
      private readonly northwindContext _northwindContext;

      public TerritoriesRepository( northwindContext northwindContext)
      {
         _northwindContext = northwindContext;
      }

      public IQueryable<Territories> GetTerritories() => _northwindContext.Territories;
   }
}
