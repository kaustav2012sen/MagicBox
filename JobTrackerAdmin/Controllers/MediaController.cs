using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobTrackerAdmin.Models;

namespace JobTrackerAdmin.Controllers
{
    public class MediaController : Controller
    {
        // GET: Media
        MediaContext mc = new MediaContext();
        public ActionResult MediaDetails()
        {
            var data = mc.Medias.ToList();
            return View(data);
        }

        public ActionResult MediaAddEdit()
        {
            return View();
        }

#region SearchMedia

        [HttpGet]
        public ActionResult MediaAddEdit(int id)
        {
            var data = mc.Medias.Find(id);
            return View(data);
        }
#endregion


        #region MediaAddEdit
        [HttpPost]
        public ActionResult MediaAddEdit(Media collection)
        {
            List<object> list = new List<object>();

            list.Add(collection.MediaID);
            list.Add(collection.MediaType);
            list.Add(collection.Rate);
            list.Add(collection.Remarks);
            object[] allItems = list.ToArray();

            if(collection.MediaID==0)
            {
                int output = mc.Database.ExecuteSqlCommand("insert into Media(MediaType,Rate,Remarks) values (@p1, @p2, @p3)", allItems);
                if(output>0)
                {
                    ViewBag.Itemmsg = "Media Added Successfully!!";
                }
            }
            else
            {

                int output = mc.Database.ExecuteSqlCommand("update Media set MediaType=@p1, Rate=@p2, Remarks=@p3 where MediaID=@p0", allItems);
                if(output>0)
                {
                    ViewBag.Itemmsg = "Media Updated Successfully!!";
                }
            }

            return View();
        }
#endregion
    }
}