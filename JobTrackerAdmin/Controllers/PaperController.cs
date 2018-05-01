using JobTrackerAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTrackerAdmin.Controllers
{
    public class PaperController : Controller
    {
        // GET: Paper
        PaperContext pc = new PaperContext();
        public ActionResult PaperDetails()
        {
            var data = pc.Papers.ToList();
            return View(data);
        }
    }
}