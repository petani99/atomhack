using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class UserCategory
    {
        public int UserCategoryId { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}