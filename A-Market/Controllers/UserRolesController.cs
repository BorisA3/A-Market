using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using A_Market.Data;
using A_Market.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace A_Market.Controllers
{
    public class UserRolesController : Controller
    {
        ApplicationDbContext dbAsp = new ApplicationDbContext();
        private A_MarketContext db = new A_MarketContext();

        // GET: UserRoles
        public ActionResult Index()
        {
            var userRoles = db.UserRoles.Include(u => u.Roles);
            return View(userRoles.ToList());
        }

        // GET: UserRoles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRoles userRoles = db.UserRoles.Find(id);
            if (userRoles == null)
            {
                return HttpNotFound();
            }
            return View(userRoles);
        }

        // GET: UserRoles/Create
        public ActionResult Create(string codigo)
        {
            //var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(dbAsp));
            //var user = userManager.FindById(codigo);
            //UserRoles userRoles = new UserRoles();
            //userRoles.UserName = user.UserName;
            ViewBag.UserName = new SelectList(dbAsp.Users, "Id", "UserName");
            ViewBag.RoleId = new SelectList(db.Roles, "RoleId", "RoleName");
            return View(/*userRoles*/);
        }

        // POST: UserRoles/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserRolesKey,UserName,RoleId")] UserRoles userRoles)
        {

          if (ModelState.IsValid)
            {

                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(dbAsp));
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(dbAsp));

                var user = userManager.FindByName(userRoles.UserName);
                
                db.UserRoles.Add(userRoles);
                db.SaveChanges();

                Roles userRole = new Roles();
                userRole = db.Roles.Find(userRoles.RoleId);

                if (!userManager.IsInRole(user.Id, userRole.RoleName))
                {
                    userManager.AddToRole(
                        user.Id,
                        userRole.RoleName
                        );
                }
                return RedirectToAction("Index");
            }

            ViewBag.RoleId = new SelectList(db.Roles, "RoleId", "RoleName", userRoles.RoleId);
            return View(userRoles);
        }

        // GET: UserRoles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRoles userRoles = db.UserRoles.Find(id);
            if (userRoles == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoleId = new SelectList(db.Roles, "RoleId", "RoleName", userRoles.RoleId);
            return View(userRoles);
        }

        // POST: UserRoles/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserRolesKey,UserName,RoleId")] UserRoles userRoles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userRoles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RoleId = new SelectList(db.Roles, "RoleId", "RoleName", userRoles.RoleId);
            return View(userRoles);
        }

        // GET: UserRoles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRoles userRoles = db.UserRoles.Find(id);
            if (userRoles == null)
            {
                return HttpNotFound();
            }


            return View(userRoles);
        }

        // POST: UserRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserRoles userRoles = db.UserRoles.Find(id);
                db.UserRoles.Remove(userRoles);
                db.SaveChanges();

                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(dbAsp));
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(dbAsp));

                var user = userManager.FindByName(userRoles.UserName);

                Roles userRole = new Roles();
                userRole = db.Roles.Find(userRoles.RoleId);

                if (userManager.IsInRole(user.Id, userRole.RoleName))
                {
                    userManager.RemoveFromRoles(
                        user.Id,
                        userRole.RoleName
                        );
                }
                return RedirectToAction("Index");
         }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
