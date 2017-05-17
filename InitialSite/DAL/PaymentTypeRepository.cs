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

        public IEnumerable<PaymentType> GetListOfPaymentTypes()
        {
            return _context.PaymentTypes;
        }


        public void Save(PaymentType newPaymentType)
        {
            _context.PaymentTypes.Add(newPaymentType);
            _context.SaveChanges();
        }

        public PaymentType GetPaymentTypeId(int id)
        {
            return _context.PaymentTypes.Find(id);
        }

        public void Delete(int id)
        {
            var paymentTypeToDelete = GetPaymentTypeId(id);
            _context.PaymentTypes.Remove(paymentTypeToDelete);
            _context.SaveChanges();
        }

        public void Edit(PaymentType paymentType)
        {

            var x = GetPaymentTypeId(paymentType.PaymentTypeId);

            x.AccountNumber = paymentType.AccountNumber;
            x.PaymentTypeName = paymentType.PaymentTypeName;

            _context.SaveChanges();
        }
    }
}