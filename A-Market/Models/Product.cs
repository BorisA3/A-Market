using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace A_Market.Models
{
    public class Product
    {
        [Key]
        [Display(Name = "Codigo")]
        public int ProductId { get; set; }

        [Display(Name = "Producto")]
        [Required]
        [MaxLength(50, ErrorMessage = "El maximo de caracteres permitidos son 50")]
        [MinLength(2, ErrorMessage = "El minimo de caracteres permitidos son 2")]
        public string ProductName { get; set; }

        [Display(Name = "Precio")]
        [Required]
        [DataType(DataType.Currency)]
        public decimal ProductPrice { get; set; }

        [Display(Name = "Ultima Compra")]
        [Required]
        [DataType(DataType.Date, ErrorMessage = "El formato del campo debe de ser una fecha")]
        public DateTime ProductLastBuy { get; set; }

        [Display(Name = "Existencia")]
        [Required]
        public float ProductStock { get; set; }

        [Display(Name = "U. medida")]
        [Required]
        [MaxLength(20, ErrorMessage = "El maximo de caracteres permitidos son 20")]
        [MinLength(2, ErrorMessage = "El minimo de caracteres permitidos son 2")]
        public string ProductMeasure { get; set; }


        
        [Display(Name = "Categoria")]
        public int CategoryKey { get; set; }

        [ForeignKey("CategoryKey")]
        public Category Category { get; set; }
    }
}