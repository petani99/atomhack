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
           return View();
        }


        public ActionResult TestLists()
        {
            ViewBag.Users = db.Users;
            ViewBag.Tasks = db.Tasks;
            ViewBag.Requests = db.Requests;
            ViewBag.Messages = db.Messages;
            ViewBag.Marks = db.Marks;
            ViewBag.UserTaskAlloweds = db.UserTaskAlloweds;
            return View("TestView");
        }


    }
}