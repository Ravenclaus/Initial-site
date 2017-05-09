using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InitialSite.Models
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }
        [Required]
        public string PaymentTypeNameType { get; set; }
        [Required]
        public int AccountNumber { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<OrderCart> OrderCarts { get; set; }
    }
}