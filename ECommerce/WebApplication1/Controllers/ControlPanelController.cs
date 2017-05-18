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
        Entities1 db = new Entities1();
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

            return View();
        }
        public ActionResult diagram()
        {
            return View();
        }
        public ActionResult directors()
        {
            List<object> directors = new List<object>();
            directors.Add(db.Users.Where(users=>users.role_id == 2).ToList());
            return View(directors);
        }
        public ActionResult leaders()
        {
            List<object> leaders = new List<object>();
            leaders.Add(db.Users.Where(users => users.role_id == 3).ToList());
            return View(leaders);
        }
        public ActionResult trainees()
        {
            List<object> trainees = new List<object>();
            trainees.Add(db.Users.Where(users => users.role_id == 4).ToList());
            return View(trainees);
        }
        public ActionResult customers()
        {
            List<object> customers = new List<object>();
            customers.Add(db.Users.Where(users => users.role_id == 5).ToList());
            return View(customers);
        }
        public ActionResult projects()
        {
            List<object> projects = new List<object>();
            User user = db.Users.Find(Convert.ToInt32(Session["user_id"]));
            if ((string)Session["role_name"]=="Admin")
            {
                projects.Add(db.Projects.ToList());
            }
            else if((string)Session["role_name"]=="Customer")
            {
                projects.Add(user.Projects.ToList());
            }
            else
            {
                if(user.TeamMembers.Count()>0)
                {
                    foreach (var TeamMember in user.TeamMembers)
                    {
                        projects.Add(TeamMember.Team.Projects.ToList());
                    }
                }
               
            }
            return View(projects);
        }
    }
}