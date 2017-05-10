using InitialSite.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InitialSite.Models;

namespace InitialSite.DAL
{
    public class ProductRepository : IProductRepository
    {
        readonly AppContext _context;

        public ProductRepository(AppContext context)
        {
            _context = context;
        }

        public void SaveProduct(Product newProduct)
        {
            _context.Products.Add(newProduct);
            _context.SaveChanges();
        }
    }
}