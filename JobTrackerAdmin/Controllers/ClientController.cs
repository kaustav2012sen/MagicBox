using JobTrackerAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTrackerAdmin.Controllers
{
    public class ClientController : Controller
    {
        DataContext db = new DataContext();
        // GET: Client
        public ActionResult ClientDetails()
        {
            var data = db.Clients.ToList();
            return View(data);
        }

        public ActionResult ClientAddEdit()
        {
            return View();
        }
    }
}