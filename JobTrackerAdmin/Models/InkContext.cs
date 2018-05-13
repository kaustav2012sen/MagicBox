using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobTrackerAdmin.Models
{
    public class InkContext:DbContext
    {
        public InkContext() : base("connect")
        {

        }

        public DbSet<Ink> Inks { get; set; }
    }
}