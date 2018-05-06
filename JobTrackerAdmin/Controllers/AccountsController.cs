using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobTrackerAdmin.Models;

namespace JobTrackerAdmin.Controllers
{
    public class AccountsController : Controller
    {
        UserContext uc = new UserContext();
        // GET: Accounts
        [HttpPost]
        public ActionResult Verification(User usercollection)
        {
            var usr = uc.Users.Where(u => u.email == usercollection.email && u.password == usercollection.password).FirstOrDefault();
            if(usr!=null)
            {
                Session["UserID"] = usr.UserID.ToString();
                Session["UserName"] = usr.email.ToString();
                Session["Role"] = usr.userRole.ToString();

                return RedirectToAction("ClientDetails", "Client");
            }
            return RedirectToAction("ClientDetails", "Client");

            //return View();
        }

        [HttpGet]
        public ActionResult Verification()
        {
            Session["Role"] = "0";
            return View();
        }
    }
}