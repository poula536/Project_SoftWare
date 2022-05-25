using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projectsw.Models;

namespace Projectsw.Controllers
{
    public class OrdersController : Controller
    {
        NewAcountEntities1 db = new NewAcountEntities1();

        // GET: Orders
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Product prod )
        {
            if (ModelState.IsValid)
            {
                db.Entry(prod.quantity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("../Account/Index");
            }


            return View();
        }
    }
}