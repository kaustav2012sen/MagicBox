using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTrackerAdmin.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        public ActionResult ClientList()
        {
            return View();
        }

        public ActionResult AddEditClient()
        {
            return View();
        }
    }
}