using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTrackerAdmin.DAL.Entity.Clients
{
    class Client_PersonalDetails
    {
        public string CP { get; set; }

        [Required(ErrorMessage="City required")]
        public string City { get; set; }

        [Required(ErrorMessage = "Contact Person required")]
        [DisplayName("Contact Person")]
        public string ContactPerson { get; set; }

        [Required(ErrorMessage = "Contact Number required")]
        [DisplayName("Contact")]
        public string Contact { get; set; }

        [Required(ErrorMessage ="Email Required")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w([-.]\w+)*\.\w+([-.]\w+)*")]
        [EmailAddress]
        public string Email { get; set; }

        public string Notes { get; set; }


    }
}
