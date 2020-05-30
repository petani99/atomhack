using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class UserTaskAllowed
    {
        public int Id { get; set; }
        public int UserCategory { get; set; }
        public int TaskCategory { get; set; }
    }
}