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


        #region ClientSearch

        [HttpGet]
        public ActionResult ClientAddEdit(int id)
        {
            var data = db.Clients.Find(id);
            return View(data);
        }
        #endregion


        #region ClientAddEdit
        [HttpPost]
        public ActionResult ClientAddEdit(Client collection)
        {
            List<object> list = new List<object>();

            list.Add(collection.clientId);
            list.Add(collection.clientName);
            list.Add(collection.clientAddress);
            list.Add(collection.clientContact);
            list.Add(collection.clientRemarks);
            object[] allItems = list.ToArray();

            if (collection.clientId == 0)
            {
                int output = db.Database.ExecuteSqlCommand("insert into Clients(clientName,clientAddress,clientContact,clientRemarks) values (@p1, @p2, @p3,@p4)", allItems);
                if (output > 0)
                {
                    ViewBag.Itemmsg = "Media Added Successfully!!";
                }
            }
            else
            {

                int output = db.Database.ExecuteSqlCommand("update Clients set clientName=@p1, clientAddress=@p2, clientContact=@p3,clientRemarks=@p4 where clientID=@p0", allItems);
                if (output > 0)
                {
                    ViewBag.Itemmsg = "Media Updated Successfully!!";

                }
            }
            return RedirectToAction("ClientDetails", "Client");


            //return View();
        }
        #endregion

    }
}