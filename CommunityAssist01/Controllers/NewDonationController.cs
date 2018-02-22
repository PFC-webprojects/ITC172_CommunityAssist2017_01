using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunityAssist01.Models;

namespace CommunityAssist01.Controllers
{
    public class NewDonationController : Controller
    {
        // GET: NewDonation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Amount")] NewDonation nd)
        {
            CommunityAssist2017Entities ca = new CommunityAssist2017Entities();
            Message msg = new Message();

            msg.Succeeded  =  !(Session["PersonKey"] is null);
            if (msg.Succeeded)  //  The user is logged in.  Process the donation.
            {
                Donation dtn = new Donation();
                dtn.DonationConfirmationCode = Guid.NewGuid();
                dtn.DonationDate = DateTime.Now;
                dtn.PersonKey = (int)Session["PersonKey"];  //  Try this.Session for more clarity
                dtn.DonationAmount = nd.Amount;
                ca.Donations.Add(dtn);
                ca.SaveChanges();

                return RedirectToAction("Result", msg);
            }
            else  //  The user is not logged in.
            {
                return View("Result", msg);
            }
        }

        public ActionResult Result(Message msg)
        {
            return View(msg);
        }
    }
}