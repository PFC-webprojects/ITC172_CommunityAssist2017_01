using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommunityAssist01.Models;

namespace CommunityAssist01.Controllers
{
    public class NewPersonController : Controller
    {
        CommunityAssist2017Entities ca = new CommunityAssist2017Entities();

        // GET: NewPerson
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include =
            "LastName, " +
            "FirstName, " +
            "Apartment, " +
            "Street, " +
            "City, " +
            "State, " +
            "ZIPCode, " +
            "Phone, " +
            "EMail, " +
            "PlainPassword"
            )] NewPerson np)
        {
            int result = ca.usp_Register(
                np.LastName,
                np.FirstName,
                np.EMail,
                np.PlainPassword,
                np.Apartment,
                np.Street,
                np.City,
                np.State,
                np.ZIPCode,
                np.Phone
                );

            Message msg = new Message();
            msg.Succeeded  =  result != -1;  //  The stored procedure usp_Register has been set up to return -1 if it fails.

            return View("Result", msg);
        }
    }
}