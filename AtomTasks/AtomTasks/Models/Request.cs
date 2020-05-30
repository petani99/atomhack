using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class Request
    { 
        public int RequestId { get; set; }
        public int Executor { get; set; }
        public int Task { get; set; }
        public int Price { get; set; }
        public long Timestamp { get; set; }
        public int RequestStatus { get; set; }
        public int UserMark { get; set; }
    }
}