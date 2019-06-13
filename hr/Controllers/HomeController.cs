using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult MyView() 
        {
            return View();
        }
        public ActionResult hr() 
        {
            return View();
        }
        public ActionResult Phr(int? id) 
        {
            if (id != null) 
            {
                ViewBag.flag = true;
                ViewBag.id = id;

            }
            else
            
                ViewBag.flag = false;
                return PartialView();
          
        }
        public ActionResult hr19()
        {
           Models.StudentEntities db = new Models.StudentEntities();

           Models.Student s1 = db.Student.FirstOrDefault();
            ViewBag["hr19"] = "";
            return View(s1);
        }
    }
}