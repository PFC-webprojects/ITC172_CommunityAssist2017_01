using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunityAssist01.Models;

namespace CommunityAssist01.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include =
            "UserName, " +
            "Password, " +
            "PersonKey"
            )] Login li)
        {
            CommunityAssist2017Entities db = new CommunityAssist2017Entities();
            li.PersonKey = 0;
            int result = db.usp_Login(li.UserName, li.Password);
            Message msg = new Message();

            msg.Succeeded  =  result != -1;
            if (msg.Succeeded)
            {
                Session["PersonKey"] = (int)(from p in db.People
                           where p.PersonEmail.Equals(li.UserName)
                           select p.PersonKey).FirstOrDefault();
                msg.UserName = (string)(from p in db.People
                                where p.PersonEmail.Equals(li.UserName)
                                select p.PersonFirstName).FirstOrDefault();

                return RedirectToAction("Result", msg);
            }
            else
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