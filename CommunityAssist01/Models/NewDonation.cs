using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CommunityAssist01.Models
{
    public class NewDonation
    {
        [Range(1, 10000000000000000000, ErrorMessage = "Please enter a feasible donation of at least $1.00.")]
        public decimal Amount { get; set; }
    }
}