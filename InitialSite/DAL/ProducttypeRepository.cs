using InitialSite.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InitialSite.Models;

namespace InitialSite.DAL
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        //EntityFramework setup:
        private readonly AppContext _context;

        public ProductTypeRepository(AppContext injectedContext)
        {
            _context = injectedContext;
        }

        //Methods
        public IEnumerable<ProductType> GetListOfProductLabels()
        {
            return _context.ProductTypes;
            //ProductTypes comes from AppContext.cs
        }
    }
}