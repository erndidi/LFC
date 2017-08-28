using LFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace LFC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title="LFC";
return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            Contact contact = new Models.Contact();
            return View(contact);
        }
        [HttpPost]
    

        public ActionResult SuccessPage()
        {
            return View();
        }
    }
}