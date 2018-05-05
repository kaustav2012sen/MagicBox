using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JobTrackerAdmin.Models
{
    public class UserContext:DbContext
    {
        public UserContext() : base("connect")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}