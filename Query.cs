using hcgraphqlnew.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace hcgraphqlnew
{
    public class Query
    {
        private northwindContext _northwindContext;
        public Query(northwindContext northwindcontext)
        {
            _northwindContext = northwindcontext;
        }
        public string TableName()
        {
            var entityTypes =  _northwindContext.Model.GetEntityTypes().Select(t => t.ClrType).ToList();

            List<object> getNames = new List<object>();
            foreach (var entity in entityTypes)
            {
                var name = entity.Name;


                return name;
                
            }


            return getNames.ToList().ToString();
            
        }
    }

    public class Greetings
    {
        public string Hello() => "World";
    }
}
