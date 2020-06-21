using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace A_Market.Models
{
    public class Supplier
    {
        [Key]

        [Display(Name = "Codigo")]
        public int SupplierKey { get; set; }

        [Display(Name = "Proveedor")]
        [Required]
        [MaxLength(50, ErrorMessage = "El maximo de caracteres permitidos son 50")]
        [MinLength(2, ErrorMessage = "El minimo de caracteres permitidos son 2")]
        public string SupplierName { get; set; }

        [Display(Name = "Telefono")]
        [DataType(DataType.PhoneNumber)]
        public string SupplierPhone { get; set; }

        [Display(Name = "Numero de Identificacion")]
        [MaxLength(30, ErrorMessage = "El maximo de caracteres permitidos son 30")]
        [MinLength(2, ErrorMessage = "El minimo de caracteres permitidos son 2")]
        public string SupplierIdentificationId { get; set; }


        [Display(Name = "Tipo de Identificacion")]
        public int IdentificationTypeKey { get; set; }

        [ForeignKey("IdentificationTypeKey")]
        public IdentificationType IdentificationType { get; set; }
    }
}
