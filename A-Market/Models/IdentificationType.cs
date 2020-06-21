using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A_Market.Models
{
    public class IdentificationType
    {
        [Key]

        [Display(Name = "Codigo")]       
        public int IdentificationTypeKey { get; set; }

        [Display(Name = "Tipo de Identificacion")]
        [Required]
        [MaxLength(50, ErrorMessage = "El maximo de caracteres permitidos son 50")]
        [MinLength(2, ErrorMessage = "El minimo de caracteres permitidos son 2")]
        public string IdentificationTypeName { get; set; }


        public virtual ICollection<Client> Clients { get; set; }

        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}