using InitialSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialSite.Controllers.Interfaces
{
    public interface IProductTypeRepository
    {
        //Only using GET method for ProductLabels
        //Database seeded with ProductLabel info
        IEnumerable<ProductType> GetListOfProductLabels();
    }
}
