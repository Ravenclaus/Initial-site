using InitialSite.Controllers.Interfaces;
using InitialSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InitialSite.Controllers
{
    public class PaymentTypeController : Controller
    {
        readonly IPaymentTypeRepository _paymentTypeRepository;

        public PaymentTypeController(IPaymentTypeRepository paymentTypeRepository)
        {
            _paymentTypeRepository = paymentTypeRepository;
        }

        // GET: PaymentType
        public ActionResult Index()
        {
            var allPaymentTypes = _paymentTypeRepository.GetListOfPaymentTypes();
            return View("index", allPaymentTypes);
        }

        [HttpGet]
        public ActionResult AddPaymentType()
        {
            return View("AddPaymentType");
        }

        [HttpPost]
        public ActionResult AddPaymentType(PaymentType newPaymentType)
        {
            _paymentTypeRepository.Save(newPaymentType);

            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _paymentTypeRepository.Delete(id);

            return RedirectToAction("index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View("Edit", _paymentTypeRepository.GetPaymentTypeId(id));
        }

        [HttpPost]
        public ActionResult Edit(PaymentType paymentType)
        {
            _paymentTypeRepository.Edit(paymentType);
            return RedirectToAction("index");

        }
    }
}