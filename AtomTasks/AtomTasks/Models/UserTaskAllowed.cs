using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class UserTaskAllowed
    {
        public int Id { get; set; }
        public UserCategory UserCategory { get; set; }
        public TaskCategory TaskCategory { get; set; }
    }
}