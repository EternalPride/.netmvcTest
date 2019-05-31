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
        public ActionResult Test() 
        {
            Models.InitData data = new Models.InitData();
            return View(data);
        }
        public ActionResult testff() 
        {
            return View();
        }

        public ActionResult creat()
        {
            List<string> list = new List <string>();
            list.Add("启用");
            list.Add("禁用");
            SelectList mlist = new SelectList(list);
            ViewBag.list = mlist;
            return View();
        }
	}
}