using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public virtual User Executor { get; set; }
        public Task Task { get; set; }
        public int Price { get; set; }
        public DateTime? Timestamp { get; set; }
        public Status RequestStatus { get; set; }
        public virtual UserMark UserMark { get; set; }
    }
}