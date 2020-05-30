using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class Request
    { 
        public int RequestId { get; set; }
        public string Task { get; set; }
        public string Executor { get; set; }
        public string Price { get; set; }
        public string Timestamp { get; set; }
        public string RequestStatus { get; set; }
    }
}