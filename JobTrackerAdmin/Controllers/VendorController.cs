using JobTrackerAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobTrackerAdmin.Controllers
{
    public class VendorController : Controller
    {
        VendorContext db = new VendorContext();
        // GET: Vendor
        public ActionResult VendorDetails()
        {

            var data = db.Vendors.ToList();
            return View(data);
        }

        #region SearchVendor

        [HttpGet]
        public ActionResult VendorAddEdit(int id)
        {
            var data = db.Vendors.Find(id);
            return View(data);
        }
        #endregion

        #region VendorAddEdit 

        [HttpPost]
        public ActionResult VendorAddEdit(Vendor collection)
        {

            List<object> lst = new List<object>(); //Bind All the Data with the model

            lst.Add(collection.VendorID);
            lst.Add(collection.VendorName);
            lst.Add(collection.VendorContact);
            lst.Add(collection.VendorAddress);
            lst.Add(collection.VendorEmail);
            lst.Add(collection.VendorPAN);
            lst.Add(collection.VendorGST);
            lst.Add(collection.VendorRemarks);
            object[] allitems = lst.ToArray();

            if (collection.VendorID == 0) // Add New Item
            {

                int output = db.Database.ExecuteSqlCommand("insert into Vendors(VendorName,VendorContact,VendorAddress,VendorEmail,VendorPAN,VendorGST,VendorRemarks) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", allitems);
                if (output > 0)
                {
                    ViewBag.Itemmsg = "Vendor Added Successfully";
                }
            }
            else // Update existing
            {
                int output = db.Database.ExecuteSqlCommand("Update Vendors set VendorName=@p1,VendorContact=@p2,VendorAddress=@p3,VendorEmail=@p4,VendorPAN=@p5,VendorGST=@p6,VendorRemarks=@p7 where VendorID=@p0", allitems);
                if (output > 0)
                {
                    ViewBag.Itemmsg = "Vendor Updated Successfully";
                }
            }
            return RedirectToAction("VendorDetails", "Vendor");




            //return View();


        }
        #endregion
    }
}