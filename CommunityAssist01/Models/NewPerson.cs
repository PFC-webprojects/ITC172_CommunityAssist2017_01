using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityAssist01.Models
{
    public class NewPerson
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Apartment { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZIPCode { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public string PlainPassword { get; set; }
    }
}