using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InitialSite.Models;

namespace InitialSite.Controllers.Interfaces
{
    public interface IOrderRepository
    {
        void Save(OrderCart newOrder);
    }
}