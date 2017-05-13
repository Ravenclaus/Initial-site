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

        //[HttpGet]
        //public IEnumerable<PaymentType> GetListOfPaymentTypes(IEnumerable<PaymentType> PaymentTypes)
        //{
        //    var allPaymentTypes = _paymentTypeRepository.GetListOfPaymentTypes();
        //    return allPaymentTypes;
        //}
    }
}