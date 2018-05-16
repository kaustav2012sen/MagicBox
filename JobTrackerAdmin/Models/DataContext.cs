using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using JobTrackerAdmin.Migrations;

namespace JobTrackerAdmin.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("connect")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext,Configuration>());
        }
        public DbSet<Client> Clients { get; set; }
    }
}