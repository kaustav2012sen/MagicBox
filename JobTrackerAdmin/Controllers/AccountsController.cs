using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTrackerAdmin.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Verification()
        {
            return View();
        }
    }
}