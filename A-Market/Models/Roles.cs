using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace A_Market.Models
{
    public class Roles
    {
        [Key]
        [Display(Name = "Codigo")]
        public int RoleId { get; set; }

        [MaxLength(256, ErrorMessage = "El tamaño maximo de caracteres prermitidos es 256")]
        [MinLength(5, ErrorMessage = "El tamaño maximo de caracteres prermitidos es 5")]
        [Display(Name = "Nombre")]
        public string RoleName { get; set; }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}