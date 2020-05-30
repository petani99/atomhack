using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public DateTime? Timestamp { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
        public Task Task { get; set; }
    }
}