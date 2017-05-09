using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InitialSite.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        public virtual ProductType ProductType{ get; set; }
   
        public virtual Customer Customer{ get; set; }

        public virtual List<OrderCart> OrderCarts { get; set; }

    }
}