using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobTrackerAdmin.Models
{
    public class Ink
    {
        [Key]
        public int InkID { get; set; }

        [Required(ErrorMessage = "Ink Type Mandatory")]
        [DisplayName("Ink Type")]
        public string InkType { get; set; }


        [DisplayName("Ink Remarks")]
        public string InkRemarks { get; set; }
    }
}