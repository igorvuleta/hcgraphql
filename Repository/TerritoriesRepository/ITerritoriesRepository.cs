using hcgraphqlnew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Repository.TerritoriesRepository
{
   public interface ITerritoriesRepository
   {
      IQueryable<Territories> GetTerritories();
   }
}
