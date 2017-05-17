using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace Ecommerce.Controllers
{
    public class ControlPanelController : Controller
    {
        Entities db = new Entities();
        // GET: ControlPanel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult overview()
        {
            ViewBag.DirectorsCount = db.Users.Where(user => user.role_id == 2).Count();
            ViewBag.LeadersCount = db.Users.Where(user => user.role_id == 3).Count();
            ViewBag.TraineesCount = db.Users.Where(user => user.role_id == 4).Count();
            ViewBag.CustomersCount = db.Users.Where(user => user.role_id == 5).Count();
            ViewBag.ProjectsCount = db.Projects.Count();
            ViewBag.AssignedProjectsCount = db.AssignedTeams.Count();

            return View();
        }
        public ActionResult diagram()
        {
            return View();
        }
        public ActionResult directors()
        {
            return View();
        }
        public ActionResult leaders()
        {
            return View();
        }
        public ActionResult trainees()
        {
            return View();
        }
        public ActionResult customers()
        {
            return View();
        }
        public ActionResult projects()
        {
            return View();
        }
    }
}