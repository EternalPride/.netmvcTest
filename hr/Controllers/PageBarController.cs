using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hr.Controllers
{
    public class PageBarController : Controller
    {
        //
        // GET: /PageBar/
        Models.StudentEntities ghr = new Models.StudentEntities();
        public ActionResult Index()
        {   int PI=Request["PI"] !=null ? Int32.Parse(Request["PI"]) :1;
            ViewBag.PI = PI;
            var q = ghr.Student.ToList();
            return View(q);
        }
	}
}