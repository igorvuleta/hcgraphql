﻿using hcgraphqlnew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Repository.RegionRepository
{
   public interface IRegionRepository
   {
      IQueryable<Region> GetRegions();
   }
}
