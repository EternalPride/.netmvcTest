using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hr.Controllers
{
    public class AchController : Controller
    {
        //
        // GET: /Ach/
        Models.OTSEntities db = new Models.OTSEntities();
        #region  原有方法
        public ActionResult Index()
        {
            var q = db.Achievement.ToList();
            return View(q);
        }
        //public ActionResult Index(FormCollection c)
        //{
        //    //var q = db.Achievement.ToList();
        //    //string name = c["name"];
        //    //string de = c["Department"];
        //    //if (name != "")
        //    //{
        //    //    q = q.Where(s => s.ClassName == name).ToList();
        //    //}
        //    //if (de != "--请选择--")
        //    //    q = q.Where(s => s.Department == de).ToList();
        //    //return View(q);

        //}
        #endregion
        #region  添加
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(FormCollection coll, string ANmae) 
        {
            Models.Achievement model = new Models.Achievement();
            model.ID = Convert.ToInt32( coll["AID"]);
            model.Name = ANmae;
            model.Semester = Request["Sem"];
            model.WoType = Request["Wotype"];
            model.XHID = Convert.ToInt32(coll["XHID"]);
            db.Achievement.Add(model);
            int result = db.SaveChanges();
            if (result > 0)
            {
                return Content("添加成功");
               
            }
            else 
            {
                return Content("失败");
            }



        }
        #endregion
        public ActionResult AChEdit(int id, FormCollection coll) 
        {
            var q = db.Achievement.Where(s => s.ID == id).FirstOrDefault();
            //摆渡人
            ViewData["ID"] = q.ID;
            ViewBag.Name = q.Name;
            ViewBag.Sem = q.Semester;
            ViewBag.XHID = q.XHID;
            return View(q);
        }
    }
}