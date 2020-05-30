using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtomTasks.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public DateTime? Timestamp { get; set; }

        public int User { get; set; }
        [ForeignKey("User")]
        public virtual User UserObj { get; set; }

        public string Text { get; set; }

        public int Task { get; set; }
        [ForeignKey("Task")]
        public virtual Task TaskObj { get; set; }
    }
}