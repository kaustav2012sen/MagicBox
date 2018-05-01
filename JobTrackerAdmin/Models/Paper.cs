using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobTrackerAdmin.Models
{
    public class Paper
    {
        [Key]
        public int PaperID { get; set; }

        [Required(ErrorMessage = "Paper Type Mandatory")]
        [DisplayName("Paper Type")]
        public string PaperType { get; set; }

        [DisplayName("Rate")]
        public int Rate { get; set; }

        [DisplayName("Additional Remarks")]
        public string clientRemarks { get; set; }

    }
}