using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Registro()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Ambiente()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return ViewBag.Title = "Login";
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                               