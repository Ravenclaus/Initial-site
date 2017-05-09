using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialSite.Models;

namespace InitialSite.Controllers.Interfaces
{
    public interface ICustomerRepository
    {
        void Save(Customer newCustomer);
        IEnumerable<Customer> GetAllCustomers();
    }
}
