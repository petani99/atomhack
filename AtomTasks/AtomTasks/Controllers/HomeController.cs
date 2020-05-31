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

        public ActionResult Index()
        {
            ViewBag.TaskCategories = db.TaskCategories;
           return View();
        }


        public ActionResult Test()
        {

            ViewBag.Tasks = db.Tasks;
            return View("Test");
        }

    }
}