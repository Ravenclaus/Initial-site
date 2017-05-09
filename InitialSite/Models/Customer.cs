using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InitialSite.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }

        public virtual List<Product> Products { get; set; }
        public virtual List<PaymentType> PaymentTypes { get; set; }
        public virtual List<OrderCart> OrderCarts { get; set; }
        

    }
}