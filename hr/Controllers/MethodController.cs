using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hr.Controllers
{
    public class MethodController : Controller
    {
        //
        // GET: /Method/
        Models.OTSEntities db = new Models.OTSEntities();
        public ActionResult Index()
        {
            var q = db.Achievement.ToList();
            return View(q);
        }
        public ActionResult Edit(int id)
        {
            var q = db.Achievement.Where(s => s.ID == id).FirstOrDefault();
            var n = db.Achievement.ToList();
            SelectList list = new SelectList(n, "WoType", "WoType", q.WoType);
            ViewBag.list = list;
            return View(q);
        }
	}
}