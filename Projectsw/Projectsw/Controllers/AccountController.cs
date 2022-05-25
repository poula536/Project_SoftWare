using Projectsw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projectsw.Controllers
{
    public class AccountController : Controller
    {
        NewAcountEntities1 db = new NewAcountEntities1();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(NewUser user)
        {
            if (ModelState.IsValid)
            {
                db.NewUsers.Add(user);
                db.SaveChanges();

                return RedirectToAction("Login");
            }


            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(NewUser user)
        {
            TempData["user_name"] = user.FullName;

            var result = db.NewUsers.Where(a => a.FullName == user.FullName && a.Password == user.Password).FirstOrDefault();
            if (result != null)
            {
                return RedirectToAction("Index");
            }
            else
                ModelState.AddModelError("", "Invalid");

            return View();
        }

    }
}