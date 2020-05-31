using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class TaskCategory
    {
        public int TaskCategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}