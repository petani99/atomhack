using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtomTasks.Models
{
    public class UserTaskAllowed
    {
        public int UserTaskAllowedId { get; set; }
        public int UserCategory { get; set; }

        [ForeignKey("UserCategory")]
        public virtual UserCategory UserCategoryObj { get; set; }
        
        public int TaskCategory { get; set; }

        [ForeignKey("TaskCategory")]
        public virtual UserCategory TaskCategoryObj { get; set; }
    }
}