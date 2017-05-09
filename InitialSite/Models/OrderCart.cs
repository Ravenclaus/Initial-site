using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InitialSite.Models
{
    public class OrderCart
    {
        [Key]
        public int OrderCartId { get; set; }

        [Required]
        public double OrderCartTotal { get; set; }

        public virtual Customer Customer{ get; set; }

        public virtual PaymentType PaymentType { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}