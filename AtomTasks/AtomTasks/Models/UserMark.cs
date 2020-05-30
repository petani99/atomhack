using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class UserMark
    {
        public int UserMarkId { get; set; }
        public int Mark { get; set; }
        public string Text { get; set; }
    }
}