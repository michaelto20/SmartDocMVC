using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using SmartDocMVC.Code;

namespace SmartDocMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/App_Data/Upload"), fileName);
                    file.SaveAs(path);

                    string fields = ValidateSmartDoc.ParseSmartDoc(fileName);
                    ViewBag.Preview = fields;
                    //context.Response.Write(fields);
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                ViewBag.Message = "Upload failed";
            }
            return View(ViewBag);

        }

        //[HttpPost]
        //public ActionResult Index(HttpContext context)
        //{
        //    try
        //    {
        //        string path = context.Request["path"];

        //        // Put smart doc in uploads folder but first
        //        // check to make sure there isn't a file with the
        //        // same name already there.  If there is delete it.
        //        FileInfo fn = new FileInfo(path);
        //        string filename = context.Server.MapPath("~/Upload/" + fn.Name);
        //        if (System.IO.File.Exists(filename))
        //        {
        //            System.IO.File.Delete(filename);
        //        }

        //        fn.CopyTo(filename);
        //        //Parser parser = new Parser(fn.Name);

        //        //string fields = ValidateSmartDoc.ParseSmartDoc(fn.Name);
        //        //context.Response.Write(fields);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Index(string str)
        //{
        //    return View();
        //}


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}