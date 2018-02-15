using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityAssist01.Models
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PersonKey { get; set; }
    }
}