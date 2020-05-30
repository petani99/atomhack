using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtomTasks.Models
{
    public class UserMark
    {
        public int UserMarkId { get; set; }
        public int Mark { get; set; }
        
        [ForeignKey("Mark")]
        public virtual Mark MarkObj { get; set; }
        public string Text { get; set; }
    }
}