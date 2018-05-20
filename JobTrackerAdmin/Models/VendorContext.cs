
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobTrackerAdmin.Models
{
    public class VendorContext:DbContext
    {
        public VendorContext() : base("connect")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<VendorContext>());

        }

        public DbSet<Vendor> Vendors { get; set; }
    }
}