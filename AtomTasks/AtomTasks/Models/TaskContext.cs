using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AtomTasks.Models
{
    public class TaskContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<UserMark> UserMarks { get; set; }
        public DbSet<StatusModel> StatusModels { get; set; }
        public DbSet<UserCategory> UserCategories { get; set; }
        public DbSet<TaskCategory> TaskCategory { get; set; }
        public DbSet<UserTaskAllowed> UserTasksAllowed { get; set; }
    }
}