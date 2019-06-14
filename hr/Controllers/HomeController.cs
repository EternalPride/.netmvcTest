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
           ViewData["hr19"] = "分工不分蛋糕";
            return View(s1);
        }
        public ActionResult s5() 
        {
            return View();
        }
        public ActionResult s6()
        {
            return Content("f输入个人违规");
        }
        public ActionResult s7() 
        {
            return View();
        
        }
        public ActionResult S12()
        {
            return Content("#S7{ font-weight:bold; font-style:italic}", "text/css");
        }
        public ActionResult S13()
        {
            return Content("这是编码后的文本内容", "text/html", System.Text.Encoding.UTF8);
        }

        public ActionResult s8() 
        {
            return Content("<script>alert('登录成功！')</script>");

        }
        public ActionResult s10() 
        {
            byte[] s10 = System.Text.Encoding.UTF8.GetBytes("地方近段时间");
            return File(s10, "text/plain", "华盛顿丰盛的.txt");
        }
        public ActionResult s11() 
        {
            return File("/Content/1.txt", "text/plain", "1.txt");
        }
        public ActionResult s14() 
        {
            return RedirectToAction("s15");
        }
        public ActionResult s15() 
        {
            return View();
        }
        public ActionResult s16() 
        {
            return RedirectToAction("s15", new { id = 1 });
        }
        public ActionResult s17() 
        {
            return RedirectToAction("s15", "Home");
        }
        public ActionResult s18() 
        {
            return RedirectToAction("s15", "Home", new { id = 1 });
        }


    }
}