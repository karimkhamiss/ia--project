using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DirectorController : Controller
    {
        public Entities1 db = new Entities1();
        // GET: Director
        public void ChooseProject()
        {
            int project_id = Convert.ToInt32(Request.Form["project_id"]);
            int user_id = Convert.ToInt32(Session["user_id"]);
            Team TeamObject = new Team();
            TeamObject.project_id = project_id;
            db.Teams.Add(TeamObject);
            db.SaveChanges();
            TeamMember TeamMemberObject = new TeamMember();
            TeamMemberObject.team_id = TeamObject.id;
            TeamMemberObject.user_id = user_id;
            db.TeamMembers.Add(TeamMemberObject);
            db.SaveChanges();
            var project = db.Projects.Find(project_id);
            project.status = 2;
            project.team_id = TeamObject.id;
            db.SaveChanges();
        }
    }
}