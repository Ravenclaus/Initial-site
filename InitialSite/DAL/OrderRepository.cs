using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InitialSite.Controllers.Interfaces;
using InitialSite.Models;

namespace InitialSite.DAL
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppContext _context;
        public OrderRepository(AppContext context)
        {
            _context = context;
        }

        public void Save(OrderCart newOrder)
        {
            _context.OrderCarts.Add(newOrder);
            _context.SaveChanges();
        }
    }
}