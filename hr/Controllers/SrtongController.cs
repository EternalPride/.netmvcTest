using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hr.Controllers
{
    public class SrtongController : Controller
    {
        //
        // GET: /Srtong/
        Models.OTSEntities db = new Models.OTSEntities();
        public ActionResult Index()
        {
            var q = db.Achievement.ToList();
            return View(q);
        }
        public ActionResult Creat()
        {
            return View();
        }
        public ActionResult Creat(Models.Achievement model) 
        {
            db.Achievement.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
	}
}