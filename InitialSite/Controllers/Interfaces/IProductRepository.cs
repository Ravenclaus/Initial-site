using InitialSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialSite.Controllers.Interfaces
{
    public interface IProductRepository
    {
        void SaveProduct(Product newProduct);
        IEnumerable<Product> GetAllProducts();
    }
}
