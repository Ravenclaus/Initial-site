using InitialSite.Controllers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InitialSite.Models;

namespace InitialSite.DAL
{
    public class PaymentTypeRepository : IPaymentTypeRepository
    {
        readonly AppContext _context;

        public PaymentTypeRepository(AppContext context)
        {
            _context = context;
        }

        public void Save(PaymentType newPaymentType)
        {
            _context.PaymentTypes.Add(newPaymentType);
            _context.SaveChanges();
        }
    }
}