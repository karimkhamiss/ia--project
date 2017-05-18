using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace Ecommerce.Controllers
{
    public class ProjectController : Controller
    {
        public Entities1 db = new Entities1();
        // GET: Project
        public ActionResult Profile(int id)
        {
            var project = db.Projects.Find(id);
            return View(project);
        }
        public void Delete(int project_id)
        {
            Project project = db.Projects.Find(project_id);
            db.Projects.Remove(project);
            db.SaveChanges();
        }
    }
}