using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InitialSite.Controllers.Interfaces;
using InitialSite.Models;

namespace InitialSite.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppContext _context;


        public CustomerRepository(AppContext context)
        {
                _context = context;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _context.Customers;
        }

        public void Save(Customer newCustomer)
        {
            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
        }
    }
}