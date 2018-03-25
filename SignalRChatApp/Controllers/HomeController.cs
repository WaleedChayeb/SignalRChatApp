using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRChatApp.Controllers
{
    public class HomeController : Controller
    { 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Chat(string name)
        {
            ViewBag.name = name;
            return View();
        }
    }
}