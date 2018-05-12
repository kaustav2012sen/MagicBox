using JobTrackerAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTrackerAdmin.Controllers
{
    public class InkController : Controller
    {
        InkContext ic = new InkContext();
        public ActionResult InkDetails()
        {
            var data = ic.Inks.ToList();
            return View(data);
        }

        #region SearchInk

        [HttpGet]
        public ActionResult InkAddEdit(int id)
        {
            var data = ic.Inks.Find(id);
            return View(data);
        }
        #endregion

        #region InkAddEdit 

        [HttpPost]
        public ActionResult InkAddEdit(Ink collection)
        {

            List<object> lst = new List<object>(); //Bind All the Data with the model

            lst.Add(collection.InkID);
            lst.Add(collection.InkType);
            lst.Add(collection.InkRemarks);
            object[] allitems = lst.ToArray();

            if (collection.InkID == 0) // Add New Item
            {

                int output = ic.Database.ExecuteSqlCommand("insert into Inks(InkType,InkRemarks) values (@p1,@p2)", allitems);
                if (output > 0)
                {
                    ViewBag.Itemmsg = "Ink Added Successfully";
                }
            }
            else // Update existing
            {
                int output = ic.Database.ExecuteSqlCommand("Update Inks set InkType=@p1,InkRemarks=@p2 where InkID=@p0", allitems);
                if (output > 0)
                {
                    ViewBag.Itemmsg = "Ink Updated Successfully";
                }
            }



            return View();


        }
        #endregion


    }
}