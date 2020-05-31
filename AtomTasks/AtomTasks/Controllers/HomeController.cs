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


        public ActionResult Test()
        {

            ViewBag.Tasks = db.Tasks;
            return View("Test");
        }

        public string TaskPoints()
        {
            string result = "{\"type\": \"FeatureCollection\",\"features\": [";
            foreach (Task task in db.Tasks)
            {
                result += "{\"type\": \"Feature\",\"id\": 0,\"geometry\":{\"type\": \"Point\",\"coordinates\": [ 56.797012069583644, 61.315602147405244 ]},"
                  + "\"properties\": {\"clusterCaption\": \"clusterCaption\",\"balloonContentHeader\": \"Название\","
                  + "\"balloonContentBody\": \"<p>Описание</p><p>Цена</p> <input type='button' value='Отозваться'>\",\"hintContent\": \"Название\"},"
                  + "\"options\": {\"iconLayout\": \"default#image\",\"iconImageHref\": \"../images/MyIcon.png\"}},";
            }
            result += result + "]}";
            return result;
        }

    }
}