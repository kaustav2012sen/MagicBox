using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobTrackerAdmin.Models
{
    public class Media
    {
        [Key]
        public int MediaID { get; set; }

        [Required(ErrorMessage ="Media Type mandatory")]
        [DisplayName("Media Type")]
        public string MediaType { get; set; }

        [DisplayName("Rate")]
        public float Rate { get; set; }

        [DisplayName("Remarks")]
        public string Remarks { get; set; }
    }
}