using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace Ecommerce.Controllers
{
   
    public class UserController : Controller
    {
        public Entities db = new Entities();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult ControlPanel_1()
        {
            return View();
        }
        public ActionResult ControlPanel_2()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login()
        {


            Entities db = new Entities();
            var email = Request.Form["email"];
            var password = Request.Form["password"];
            var user = db.Users.Single(a => a.e_mail == email && a.first_name == password);
            var role = db.Roles.Single(b => b.id == user.role_id);
            if (user != null)
            {
                Session["user_id"] = user.id;
                Session["role_id"] = user.role_id;
                Session["role_name"] = role.name ;
                Session["firstname"] = user.first_name;
                Session["lastname"] = user.last_name;
                Session["email"] = user.e_mail;
                Session["picture"] = user.picture;
                Session["phone"] = user.phone;
                return RedirectToAction("../home/homepage");
            }
            else
            {
                ModelState.AddModelError("", "Email or Password is wrong");
            }

            return View();

        }
        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("../");
        }
        public ActionResult Update(int id)
        {
            User x = db.Users.Find(id);
            if (x == null)
                return View("Not Found");
            else
                return View(x);
        }
    }
}