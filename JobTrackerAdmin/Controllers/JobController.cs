using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTrackerAdmin.Controllers
{
    public class JobController : Controller
    {
        // GET: Job
        public ActionResult JobDetails()
        {
            return View();
        }

        public ActionResult AddEditJob()
        {
            return View();
        }
    }
}