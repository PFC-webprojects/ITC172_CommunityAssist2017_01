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

        public string UserName { get; set; }

        public string RegistrationText
        {
            get
            {
                return this.Succeeded ?
                    "Thank you for registering." :
                    "Sorry, but something seems to have gone wrong with the registration.";
            }
        }

        public string LoginText
        {
            get
            {
<<<<<<< HEAD
                return this.Succeeded ?
                    "Welcome, " + this.UserName + ".  You may now make a donation or apply for a grant." :
=======
<<<<<<< HEAD
                return this.Succeeded ?
                    "Welcome, " + this.UserName + ".  You may now make a donation or apply for a grant." :
=======
                return Succeeded ?
                    "Welcome, " + UserName + ".  You may now make a donation or apply for a grant." :
>>>>>>> 71ad8908f1e959c6d19ae59a056a292876927ec7
>>>>>>> e499d0f295370ffd31ea4cdad325c702932afd1f
                    "Sorry, invalid login.  Please try to log in again, or, " +
                    "if you have yet to register with us, then please do so.";
            }
        }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> e499d0f295370ffd31ea4cdad325c702932afd1f

        public string DonationText
        {
            get
            {
                return this.Succeeded ?
                    "Thank you for your donation." :
                    "We appreciate your interest in donating to Community Assist.  " +
                    "Please log in first.  Then we will be able to receive your donation.";
            }
        }
<<<<<<< HEAD

        public string ApplicationText
        {
            get
            {
                return this.Succeeded ?
                    "Thank you for your grant application.  We will respond within three days." :
                    "We appreciate your interest in applying for a grant from Community Assist.  " +
                    "Please log in first.  Then we will be able to receive your grant request.";
            }
        }
=======
=======
>>>>>>> 71ad8908f1e959c6d19ae59a056a292876927ec7
>>>>>>> e499d0f295370ffd31ea4cdad325c702932afd1f
    }
}