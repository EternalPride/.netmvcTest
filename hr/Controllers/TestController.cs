using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hr.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            Models.Person pe = new Models.Person();
            List<Models.Person> list = new List<Models.Person>();
            pe.Age = 50;
            pe.Name = "浩然";
            list.Add(pe);
            return View(list);
        }
	}
}