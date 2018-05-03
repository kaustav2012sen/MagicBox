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

        public ActionResult PaperAddEdit()
        {
            return View();
        }

        [HttpGet]
        public ActionResult PaperAddEdit(int id)
        {
            var data = pc.Papers.Find(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult PaperAddEdit(Paper collection)
        {
            if(collection.PaperID==0)
            {
                List<object> lst = new List<object>();

                //lst.Add(collection.PaperID);
                lst.Add(collection.PaperType);
                lst.Add(collection.Rate);
                lst.Add(collection.clientRemarks);
                object[] allitems = lst.ToArray();
                int output = pc.Database.ExecuteSqlCommand("insert into Papers(PaperType,Rate,clientRemarks) values (@p0,@p1,@p2)", allitems);
                if(output>0)
                {
                    ViewBag.Itemmsg = "Paper Added Successfully";
                }
            }
            else
            {
                List<object> lst = new List<object>();

                lst.Add(collection.PaperID);
                lst.Add(collection.PaperType);
                lst.Add(collection.Rate);
                lst.Add(collection.clientRemarks);
                object[] allitems = lst.ToArray();
                int output = pc.Database.ExecuteSqlCommand("Update Papers set PaperType=@p1,Rate=@p2,clientRemarks=@p3 where Paperid=@p0", allitems);
                if (output > 0)
                {
                    ViewBag.Itemmsg = "Paper Updated Successfully";
                }
            }
            
            

            return View();

            
        }
    }
}