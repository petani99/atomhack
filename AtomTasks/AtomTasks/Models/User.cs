﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtomTasks.Models
{
    public class User
    { 
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public int? UserCategory { get; set; }

        [ForeignKey("UserCategory")]
        public virtual UserCategory UserCategoryObj { get; set; }
        public string Cellphone { get; set; }
    }
}