using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommunityAssist01.Models
{
    /*  As a slight change to the letter but not the spirit of the assignment instructions,
     *  I added a bool property, Succeeded, to the Message class so that I could use that
     *  to either include or exclude an extra ActionLink / anchor tag to Result.cshtml .
     *  While I was at it, I refactored the MessageText property to a read-only property
     *  whose value is determined by the value of Succeeded.
     */ 
    public class Message
    {
        public bool Succeeded { get; set; }
        public string MessageText
        {
            get
            {
                return Succeeded ?
                    "Thank you for registering." :
                    "Sorry, but something seems to have gone wrong with the registration.";
            }
        }
    }
}