using A_Market.Data;
using A_Market.Models;
using A_Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_Market.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Index()
        {
            return View();
        }

        //Get: Sale/Create
        public ActionResult Create()
        {
            return View();
        }

        // Post: Create
        [HttpPost]
        public ActionResult Create(SaleViewModel salesViewModel)
        {
            try
            {
                using (A_MarketContext db = new A_MarketContext())
                {
                    Sale sale = new Sale{
                        ClientKey = salesViewModel.ClientKey, 
                        SaleDate = DateTime.Now
                    };

                    db.Sales.Add(sale);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View(salesViewModel);
            }

            //return View();
        }

    }
}