using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTrackerAdmin.Controllers
{
    public class ReportsController : Controller
    {
        // GET: Reports
        public ActionResult DailyReport()
        {
            return View();
        }

        public ActionResult MonthlyReport()
        {
            return View();
        }

        public ActionResult BillingDetails()
        {
            return View();
        }

        public ActionResult PaymentTracker()
        {
            return View();
        }
    }
}