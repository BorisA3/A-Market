using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace A_Market.Data
{
    public class A_MarketContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public A_MarketContext() : base("name=A_MarketContext")
        {
        }

        public System.Data.Entity.DbSet<A_Market.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<A_Market.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<A_Market.Models.Supplier> Suppliers { get; set; }

        public System.Data.Entity.DbSet<A_Market.Models.IdentificationType> IdentificationTypes { get; set; }

        public System.Data.Entity.DbSet<A_Market.Models.Client> Clients { get; set; }

        public System.Data.Entity.DbSet<A_Market.Models.Roles> Roles { get; set; }

        public System.Data.Entity.DbSet<A_Market.Models.Sale> Sales { get; set; }

        public System.Data.Entity.DbSet<A_Market.Models.SaleDetails> SaleDetails { get; set; }

        public System.Data.Entity.DbSet<A_Market.Models.UserRoles> UserRoles { get; set; }
    }
}
