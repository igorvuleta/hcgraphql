using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;
using Microsoft.EntityFrameworkCore;

namespace hcgraphqlnew.Repository.OrderDetailsRepository
{
   public class OrderDetailsRepository : IOrderDetailsRepository
   {
      private readonly northwindContext _northwindContext;
      public OrderDetailsRepository(northwindContext northwindContext) => _northwindContext = northwindContext;

      public IQueryable<OrderDetails> GetOrderDetails () => _northwindContext.OrderDetails;

      public async Task<IEnumerable<OrderDetails>> GetOrdersDetailsList(int? id) => await _northwindContext.OrderDetails.Where(o => o.OrderId == id).ToListAsync();
     
   }
}
