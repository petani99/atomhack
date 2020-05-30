using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtomTasks.Models
{
    public class Request
    {
        public int RequestId { get; set; }
       
        public int? Executor { get; set; }
        [ForeignKey("Executor")]
        public virtual User ExecutorObj { get; set; }

        public int Task { get; set; }
        [ForeignKey("Task")]
        public virtual Task TaskObj { get; set; }

        public int Price { get; set; }
        public DateTime? Timestamp { get; set; }
        
        public int RequestStatus { get; set; }
        [ForeignKey("RequestStatus")]
        public virtual Status RequestStatusObj { get; set; }

        public int? UserMark { get; set; }
        [ForeignKey("UserMark")]
        public virtual UserMark UserMarkObj { get; set; }
    }
}