using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using SmartDocMVC.Code;
using SmartDocMVC.Data;

namespace SmartDocMVC.Controllers
{
    public class HomeController : Controller
    {
        Student stud = new Student();
        string path = "";
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
                    path = Path.Combine(Server.MapPath("~/App_Data/Upload"), fileName);
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    file.SaveAs(path);

                    stud = ValidateSmartDoc.ParseSmartDoc(fileName);

                    if (stud != null)
                    {
                        TempData["stud"] = stud;
                        ViewBag.Message = "First Name: " + stud.FirstName + "\\n" +
                                          "Last Name: " + stud.LastName + "\\n" +
                                          "Age: " + stud.Age.ToString();
                    }else
                    {
                        ViewBag.Message = "Could not validate your document.";
                    }

                    
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                ViewBag.Message = "Upload failed";
            }
            return View(ViewBag);

        }

        [HttpPost]
        public ActionResult UpdateDB(bool save)
        {
            if (save)
            {
                stud = (Student)TempData["stud"];
                using (DataModel db = new DataModel())
                {
                    db.Students.Add(stud);
                    db.SaveChanges();
                }
            }else
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
            return View();
        }

       
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