﻿using System;
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
<<<<<<< HEAD
            CommunityAssist2017Entities ca = new CommunityAssist2017Entities();
=======
            CommunityAssist2017Entities ca = new CommunityAssist2017Entities();  //  Am not using this?
>>>>>>> e499d0f295370ffd31ea4cdad325c702932afd1f
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
<<<<<<< HEAD
            else  //  The user is not logged in.
=======
            else  //  The user is not logged in.  (I guess Session is a superglobal variable, as is $_SESSION in PHP?)
>>>>>>> e499d0f295370ffd31ea4cdad325c702932afd1f
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