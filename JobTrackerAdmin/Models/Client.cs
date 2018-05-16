using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobTrackerAdmin.Models
{
    public class Client
    {
        [Key]
        public int clientId { get; set; }

        [Required(ErrorMessage ="Client Name Mandatory")]
        [DisplayName("Client Name")]
        public string clientName { get; set; }

        [DisplayName("Client Address")]
        public string clientAddress { get; set; }

        [Required(ErrorMessage ="Contact Number Mandatory")]
        [DisplayName("Client Contact")]
        public double clientContact { get; set; }

        [DisplayName("Client PAN")]
        public string clientPAN { get; set; }

        [DisplayName("Client GST")]
        public string clientGST { get; set; }

        [DisplayName("Client Remarks")]
        public string clientRemarks { get; set; }

    }
}