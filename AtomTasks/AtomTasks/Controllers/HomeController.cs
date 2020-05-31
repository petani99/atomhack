using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtomTasks.Models;

namespace AtomTasks.Controllers
{
    public class HomeController : Controller
    {
        readonly TaskContext db = new TaskContext();

        public ActionResult Index( int task )
        {
            ViewBag.TaskCategories = db.TaskCategories;
            ViewBag.Requests = db.Requests.Where(x => x.Task.Equals(task));
            return View();
        }


        public ActionResult Test()
        {

            ViewBag.Tasks = db.Tasks;
            return View("Test");
        }

    }
}