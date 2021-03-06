﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hcgraphqlnew.Models;
using Microsoft.EntityFrameworkCore;

namespace hcgraphqlnew.Repository.OrdersRepository
{
   public class OrdersRepository : IOrdersRepository
   {
      private readonly northwindContext _northwindContext;
      public OrdersRepository(northwindContext northwindContext) => _northwindContext = northwindContext;

      public async Task<Orders> GetOrder(int id) => await _northwindContext.Orders.Where(o => o.OrderId == id).FirstOrDefaultAsync();

      public IQueryable<Orders> GetOrders () => _northwindContext.Orders;

      public async Task<IEnumerable<Orders>> GetOrdersList(int? id) => await _northwindContext.Orders.Where(o => o.OrderId == id).ToListAsync();

      public async Task<IEnumerable<Orders>> GetOrdersListForCustomer(string id) => await _northwindContext.Orders.Where(o => o.CustomerId == id).ToListAsync();
     
   }
}
