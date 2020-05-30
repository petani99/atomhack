using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class Message
    { 
        public int MessageId { get; set; }
        public long Timestamp { get; set; }
        public int User { get; set; }
        public string Text { get; set; }
        public int Task { get; set; }
    }
}