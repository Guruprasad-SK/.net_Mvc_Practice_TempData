using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempDataTutorial.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index1()
        {
            TempData["MyKey"] = "This My Key data";
            return View();
        }
        public ActionResult Index2()
        {
            Session.Abandon();
            ViewBag.MyKeyData = TempData.Peek("MyKey");
           // TempData.Keep("MyKey");
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.MyKeyData = TempData["MyKey"];
            return View();
        }
    }
}