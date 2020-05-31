using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel.Web;
using System.Web.Http;
using System.Web.Http.Description;
using AtomTasks.Models;

namespace AtomTasks.Controllers
{
    public class TasksController : ApiController
    {
        private TaskContext db = new TaskContext();

        // GET: api/Tasks
        public string GetTasks()
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

        // GET: api/Tasks/5
        [ResponseType(typeof(Task))]
        public IHttpActionResult GetTask(int id)
        {
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return NotFound();
            }

            return Ok(task);
        }

        // PUT: api/Tasks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTask(int id, Task task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != task.TaskId)
            {
                return BadRequest();
            }

            db.Entry(task).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Tasks
        [ResponseType(typeof(Task))]
        public IHttpActionResult PostTask(Task task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tasks.Add(task);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = task.TaskId }, task);
        }

        // DELETE: api/Tasks/5
        [ResponseType(typeof(Task))]
        public IHttpActionResult DeleteTask(int id)
        {
            Task task = db.Tasks.Find(id);
            if (task == null)
            {
                return NotFound();
            }

            db.Tasks.Remove(task);
            db.SaveChanges();

            return Ok(task);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TaskExists(int id)
        {
            return db.Tasks.Count(e => e.TaskId == id) > 0;
        }
    }
}