using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class Mark
    {
        public int UserMarkId { get; set; }
        public int MarkId { get; set; }
        public string Text { get; set; }
    }
}