using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace A_Market.Models
{
    public class UserRoles
    {
        [Key]
        [Display(Name = "Codigo")]
        public int UserRolesKey { get; set; }

        [MaxLength(256, ErrorMessage = "El tamaño maximo de caracteres prermitidos es 256")]
        [MinLength(5, ErrorMessage = "El tamaño maximo de caracteres prermitidos es 5")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Display(Name = "Role Codigo")]
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Roles Roles { get; set; }
    }
}