using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;

namespace hcgraphqlnew.Repository.OrdersRepository
{
   public class OrdersRepository : IOrdersRepository
   {
      private readonly northwindContext _northwindContext;
      public OrdersRepository(northwindContext northwindContext) => _northwindContext = northwindContext;

      public IQueryable<Orders> GetOrders () => _northwindContext.Orders;
   }
}
