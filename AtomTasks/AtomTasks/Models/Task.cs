using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public User Customer { get; set; }
        public TaskCategory TaskCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StartPrice { get; set; }
        public DateTime Date { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public Status TaskStatus { get; set; }
        public virtual UserMark UserMark { get; set; }
    }
}