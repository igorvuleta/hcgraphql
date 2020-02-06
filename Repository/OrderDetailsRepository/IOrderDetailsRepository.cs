using hcgraphqlnew.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hcgraphqlnew.Repository.OrderDetailsRepository
{
  public interface IOrderDetailsRepository
   {
      IQueryable<OrderDetails> GetOrderDetails();
      Task<IEnumerable<OrderDetails>> GetOrdersDetailsList(int? id);
   }
}
