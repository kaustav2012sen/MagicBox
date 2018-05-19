using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobTrackerAdmin.Models
{
    public class Vendor
    {
        [Key]
        public int VendorID { get; set; }

        [Required(ErrorMessage = "Vendor Name Mandatory")]
        [DisplayName("Vendor Name")]
        public string VendorName { get; set; }

        [DisplayName("Vendor Address")]
        public string VendorAddress { get; set; }

        [Required(ErrorMessage = "Contact Number Mandatory")]
        [DisplayName("Vendor Contact")]
        public double VendorContact { get; set; }

        [DisplayName("Vendor Email")]
        public string VendorEmail { get; set; }

        [DisplayName("Vendor PAN")]
        public string VendorPAN { get; set; }

        [DisplayName("Vendor GST")]
        public string VendorGST { get; set; }

        [DisplayName("Vendor Remarks")]
        public string VendorRemarks { get; set; }
    }
}