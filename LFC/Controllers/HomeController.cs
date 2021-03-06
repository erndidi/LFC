﻿using LFC.Models;
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
            
            return View();
        }
               

        public ActionResult About()
        {
            // return PartialView("_About");
            return View();
        }

        public ActionResult Contact()
        {
            Contact contact = new Models.Contact();
            // return PartialView("_Contact");
            return View(contact);
        }
    
        public ActionResult ContactMe()
        {
            Contact contact = new Models.Contact();
            return View(contact);
        }

        public ActionResult SuccessPage()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult EmailMarketing()
        {
            //return PartialView("_EmailMarketing");
            return View();
        }

        public ActionResult Blog()
        {
            // return PartialView("_Blog");
            return View();
        }

        public ActionResult Error(string id)
        {
            return View();
        }
    }
}