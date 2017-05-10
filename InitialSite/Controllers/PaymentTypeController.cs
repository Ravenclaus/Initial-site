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
            return View("index");
        }

        [HttpPost]
        public ActionResult AddPaymentType(PaymentType newPaymentType)
        {
            _paymentTypeRepository.Save(newPaymentType);

            return View("index");
        }
    }
}