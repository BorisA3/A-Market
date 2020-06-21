using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Windows.Input;

namespace A_Market.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Codigo")]
        public int CategoryKey { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        [MaxLength(50, ErrorMessage = "El maximo de caractes premitidos son 50")]
        public string CategoryName { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(150, ErrorMessage = "El maximo de caractes premitidos son 150")]
        public string CategoryDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}