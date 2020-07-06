using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace A_Market.Models
{
    public class SaleDetails
    {
        [Key]
        public int SaleDetailsKey { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int SaleDetailsQuantity  { get; set; }
        public Decimal SaleDetailsSubTotal { get; set; }
        public int SaleKey { get; set; }

        [ForeignKey("SaleKey")]
        public Sale Sale { get; set; }


    }
}