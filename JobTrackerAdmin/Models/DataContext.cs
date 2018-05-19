using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace JobTrackerAdmin.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("connect")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());

        }
        public DbSet<Client> Clients { get; set; }
    }
}