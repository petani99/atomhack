using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class TaskDbInitializer : DropCreateDatabaseAlways<TaskContext>
    {
        protected override void Seed( TaskContext db )
        {
            db.Users.Add( new User { UserId = 1, Login = "petani", Password  = "1234", Name  = "Наташа :))", UserCategory  = 1, Cellphone  = "88005553535"} );
            base.Seed( db );
        }
    }
}