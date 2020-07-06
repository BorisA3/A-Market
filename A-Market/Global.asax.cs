using A_Market.Data;
using A_Market.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Roles = A_Market.Models.Roles;

namespace A_Market
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<A_Market.Data.A_MarketContext, A_Market.Migrations.Configuration>());

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //------Iniciar Base de Datos----
            ApplicationDbContext db = new ApplicationDbContext();
            A_MarketContext dbAsp = new A_MarketContext();

            CreateRoles(db,dbAsp);
            CreateUsers(db);
            AddPermisionsToUser(db);

        }

       


        //----Creacion de roles-------
        private void CreateRoles(ApplicationDbContext db , A_MarketContext dbAsp)
        {

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
           
            //-----Definir rol Admin------

            if (!roleManager.RoleExists ("admin"))
            {
                Roles roles = new Roles();
                roles.RoleName = "admin";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("admin"));
            }

            //--------------Categoria roles-----------------
            if (!roleManager.RoleExists("CreateCategory"))
            {
                Roles roles = new Roles();
                roles.RoleName = "CreateCategory";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("CreateCategory"));
            }
            if (!roleManager.RoleExists("EditCategory"))
            {
                Roles roles = new Roles();
                roles.RoleName = "EditCategory";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("EditCategory"));
            }
            if (!roleManager.RoleExists("DeleteCategory"))
            {
                Roles roles = new Roles();
                roles.RoleName = "DeleteCategory";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("DeleteCategory"));
            }
            if (!roleManager.RoleExists("DetailsCategory"))
            {
                Roles roles = new Roles();
                roles.RoleName = "DetailsCategory";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("DetailsCategory"));
            }
            if (!roleManager.RoleExists("IndexCategory"))
            {
                Roles roles = new Roles();
                roles.RoleName = "IndexCategory";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("IndexCategory"));
            }

            //--------------Productos roles-----------------
            if (!roleManager.RoleExists("CreateProduct"))
            {
                Roles roles = new Roles();
                roles.RoleName = "CreateProduct";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("CreateProduct"));
            }
            if (!roleManager.RoleExists("EditProduct"))
            {
                Roles roles = new Roles();
                roles.RoleName = "EditProduct";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("EditProduct"));
            }
            if (!roleManager.RoleExists("DeleteProduct"))
            {
                Roles roles = new Roles();
                roles.RoleName = "DeleteProduct";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("DeleteProduct"));
            }
            if (!roleManager.RoleExists("DetailsProduct"))
            {
                Roles roles = new Roles();
                roles.RoleName = "DetailsProduct";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("DetailsProduct"));
            }
            if (!roleManager.RoleExists("IndexProduct"))
            {
                Roles roles = new Roles();
                roles.RoleName = "IndexProduct";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("IndexProduct"));
            }

            //--------------IdentificationType roles-----------------
            if (!roleManager.RoleExists("CreateIdentificationType"))
            {
                Roles roles = new Roles();
                roles.RoleName = "CreateIdentificationType";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("CreateIdentificationType"));
            }
            if (!roleManager.RoleExists("EditIdentificationType"))
            {
                Roles roles = new Roles();
                roles.RoleName = "EditIdentificationType";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("EditIdentificationType"));
            }
            if (!roleManager.RoleExists("DeleteIdentificationType"))
            {
                Roles roles = new Roles();
                roles.RoleName = "DeleteIdentificationType";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("DeleteIdentificationType"));
            }
            if (!roleManager.RoleExists("DetailsIdentificationType"))
            {
                Roles roles = new Roles();
                roles.RoleName = "DetailsIdentificationType";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("DetailsIdentificationType"));
            }
            if (!roleManager.RoleExists("IndexIdentificationType"))
            {
                Roles roles = new Roles();
                roles.RoleName = "IndexIdentificationType";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("IndexIdentificationType"));
            }
            //--------------Suppliers roles-----------------
            if (!roleManager.RoleExists("CreateSuppliers"))
            {
                Roles roles = new Roles();
                roles.RoleName = "CreateSuppliers";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("CreateSuppliers"));
            }
            if (!roleManager.RoleExists("EditSuppliers"))
            {
                Roles roles = new Roles();
                roles.RoleName = "EditSuppliers";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("EditSuppliers"));
            }
            if (!roleManager.RoleExists("DeleteSuppliers"))
            {
                Roles roles = new Roles();
                roles.RoleName = "DeleteSuppliers";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("DeleteSuppliers"));
            }
            if (!roleManager.RoleExists("DetailsSuppliers"))
            {
                Roles roles = new Roles();
                roles.RoleName = "DetailsSuppliers";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("DetailsSuppliers"));
            }
            if (!roleManager.RoleExists("IndexSuppliers"))
            {
                Roles roles = new Roles();
                roles.RoleName = "IndexSuppliers";
                dbAsp.Roles.Add(roles);
                dbAsp.SaveChanges();
                roleManager.Create(new IdentityRole("IndexSuppliers"));
            }

        }
        
        //----Creacion de Usuarios-------
        private void CreateUsers(ApplicationDbContext db)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = userManager.FindByEmail("admin@me.com");

            if (user == null)
            {
                user = new ApplicationUser
                {
                    UserName = "admin",
                    Email = "admin@me.com"
                };
                userManager.Create(user, "Admin2020");
            }
        }

        //----Agregar Roles(Asignar)-----------
        private void AddPermisionsToUser(ApplicationDbContext db)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            var user = userManager.FindByEmail("admin@me.com");

            if (!userManager.IsInRole(user.Id, "admin"))
            {
                userManager.AddToRole(
                    user.Id,
                    "admin"
                    );
            }

         
        }


    }
}
