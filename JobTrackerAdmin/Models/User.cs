using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobTrackerAdmin.Models
{
    public class User
    {
        [Required(ErrorMessage ="First Name mantatory")]
        [DisplayName("First Name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Last Name mantatory")]
        [DisplayName("Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage ="Email mandatory")]
        public string email { get; set; }


    }
}