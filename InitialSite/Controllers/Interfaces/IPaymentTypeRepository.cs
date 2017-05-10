using InitialSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialSite.Controllers.Interfaces
{
    public interface IPaymentTypeRepository
    {
        void Save(PaymentType newPaymentType);
    }
}
