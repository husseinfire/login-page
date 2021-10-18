using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class RegistrationUserController : Controller
    {
        //This project is data base code first
        // You can make a data base migration
        // And after that, he wrote a user and password in the data base
        // And after that, try the code

        private DbContainer db = new DbContainer();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login([Bind(Include = "Login, Password")]RegistrationUser registrationUser)
        {
            var rec = db.RegistrationUser
                .Where(x => x.Login == registrationUser.Login && x.Password == registrationUser.Password).ToList()
                .FirstOrDefault();
            if (rec != null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.error = "invild user";
                return View(registrationUser);
            }
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
