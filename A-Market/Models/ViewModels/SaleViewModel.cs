using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A_Market.Models.ViewModels
{
    public class SaleViewModel
    {
        [Display(Name = "Codigo")]
        public int ClientKey { get; set; }

        [Display(Name = "Nombre")]
        public string ClienteName { get; set; }

        [Display(Name = "Total")]
        public decimal SaleTotal { 
            get
            {
                decimal tot = 0;

                if (SaleDetails != null)
                {
                    foreach (var producto in SaleDetails)
                    {
                        tot += producto.SaleDetailsTotal;
                    }
                }
                return tot;
            }
            
        }
        public List<SaleDetailsViewModel> SaleDetails { get; set; }

    }
}