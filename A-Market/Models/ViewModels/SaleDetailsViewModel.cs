using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace A_Market.Models.ViewModels
{
    public class SaleDetailsViewModel
    {
        [Display(Name = "Codigo")]
        public int ProductId { get; set; }

        [Display(Name = "Nombre")]
        public string ProductName { get; set; }

        [Display(Name = "Precio")]
        public decimal ProductPrice { get; set; }

        [Display(Name = "Cantidad")]
        public int ProductQuantity { get; set; }

        [Display(Name = "Sub Total")]
        public decimal SaleDetailsTotal {
            get {
                return ProductPrice * ProductQuantity;
                }
        }
    }
}