﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobTrackerAdmin.Models
{
    public class PaperContext:DbContext
    {
        public PaperContext() : base("connect")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PaperContext>());

        }

        public DbSet<Paper> Papers { get; set; }
    }
}