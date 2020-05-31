using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtomTasks.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        public int Customer { get; set; }
        [ForeignKey("Customer")]
        public virtual User CustomerObj { get; set; }
               
        public int TaskCategory { get; set; }
        [ForeignKey("TaskCategory")]
        public virtual TaskCategory TaskCategoryObj { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int StartPrice { get; set; }
        public DateTime? Date { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        
        public int TaskStatus { get; set; }
        [ForeignKey("TaskStatus")]
        public virtual Status TaskStatusObj { get; set; }

        public int? UserMark { get; set; }
        [ForeignKey("UserMark")]
        public virtual UserMark UserMarkObj { get; set; }
    }
}