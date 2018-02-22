using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> e499d0f295370ffd31ea4cdad325c702932afd1f

namespace CommunityAssist01.Models
{
    public class NewDonation
    {
<<<<<<< HEAD
        [Range(1, 10000000000000000000, ErrorMessage = "Please enter a feasible donation of at least $1.00.")]
=======
>>>>>>> e499d0f295370ffd31ea4cdad325c702932afd1f
        public decimal Amount { get; set; }
    }
}