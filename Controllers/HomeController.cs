using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnjularMVCTestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View();
            return new FilePathResult("~/views/Home/Index.html", "text/html");
        }

    }
}