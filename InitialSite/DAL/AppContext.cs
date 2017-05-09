using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using InitialSite.Models;

namespace InitialSite.DAL
{
    public class AppContext: DbContext
    {
        public AppContext() : base("InitialSite") { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<OrderCart> OrderCarts { get; set; }

    }
}