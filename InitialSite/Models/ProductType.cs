using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InitialSite.Models
{
    public class ProductType
    {
        [Key]
        public int ProductTypeId { get; set; }
        [Required]
        public string ProductLabel { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}