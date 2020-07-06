using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace A_Market.Models
{
    public class Sale
    {
        [Key]
        public int SaleKey { get; set; }
        public DateTime SaleDate { get; set; }
        public int ClientKey { get; set; }

        [ForeignKey("ClientKey")]
        public Client Client { get; set; }

        public virtual ICollection<SaleDetails> SaleDetails { get; set; }


    }
}