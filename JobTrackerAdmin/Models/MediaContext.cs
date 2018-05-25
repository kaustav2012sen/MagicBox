using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JobTrackerAdmin.Models
{
    public class MediaContext:DbContext
    {
        public MediaContext() : base("connect")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MediaContext>());

        }

        public DbSet<Media> Medias { get; set; }
    }
}