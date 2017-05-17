﻿using InitialSite.Controllers.Interfaces;
using InitialSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InitialSite.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository _productRepository;

        public ProductController(IProductRepository ProductRepository)
        {
            _productRepository = ProductRepository;
        }

        // GET: Product
        public ActionResult Index()
        {
            //return View("index/product");
            var AllProduct = _productRepository.GetAllProducts();
            return View("index", AllProduct);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product newProduct)
        {
            try
            {
                _productRepository.SaveProduct(newProduct);

                return RedirectToAction("Index/product");
            }
            catch
            {
                return View("index/product");
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
