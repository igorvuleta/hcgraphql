using hcgraphqlnew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Repository.OrdersRepository
{
   public interface IOrdersRepository
   {
      IQueryable<Orders> GetOrders();
      Task<IEnumerable<Orders>> GetOrdersList(int? id);
   }
}
