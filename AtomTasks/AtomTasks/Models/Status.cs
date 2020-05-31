using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtomTasks.Models
{
    [Table("Statuses")]
    public class Status
    {
        public int StatusId { get; set; }
        public string ClassName { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}