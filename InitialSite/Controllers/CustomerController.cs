﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InitialSite.Controllers.Interfaces;
using InitialSite.Models;

namespace InitialSite.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: Customer
        public ActionResult Index()
        {
           
            return View("index");
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer newCustomer)
        {
            _customerRepository.Save(newCustomer);

            return View("index");
        }

        [HttpGet]
        public ActionResult GrabAllCustomers()
        {
            ViewBag.Customers = _customerRepository.GetAllCustomers().ToList();

            return View("index");
        }
        
      
    }
}