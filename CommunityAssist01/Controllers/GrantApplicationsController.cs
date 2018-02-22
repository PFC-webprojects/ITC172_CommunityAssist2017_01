using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunityAssist01.Models;

namespace CommunityAssist01.Controllers
{
    public class GrantApplicationsController : Controller
    {
        CommunityAssist2017Entities ca = new CommunityAssist2017Entities();

        // GET: GrantApplications
        public ActionResult Index()
        {
            ViewBag.GrantTypeKey = new SelectList(ca.GrantTypes, "GrantTypeKey", "GrantTypeName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include =
            "GrantTypeKey, " +
            "GrantApplicationRequestAmount, " +
            "GrantApplicationReason "
            )] GrantApplication ga)
        {
            Message msg = new Message();

            msg.Succeeded  =  !(this.Session["PersonKey"] is null);
            if (msg.Succeeded)  //  The user is logged in.  Process the grant request application.
            {
                ga.PersonKey = (int)this.Session["PersonKey"];
                ga.GrantAppicationDate = DateTime.Now;
                ga.GrantApplicationStatusKey = 1;  //  A GrantApplicationStatusKey of 1 means Pending.

                ca.GrantApplications.Add(ga);
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