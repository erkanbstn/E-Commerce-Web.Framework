using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DenizAyakkabi.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        public ActionResult MainPage()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}