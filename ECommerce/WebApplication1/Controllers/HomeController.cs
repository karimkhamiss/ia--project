using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        Entities1 db = new Entities1();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HomePage()
        {
            List<object> projects = new List<object>();
            projects.Add(db.Projects.Where(project => project.status == 1).ToList());
            return View(projects);
        }
    }
}