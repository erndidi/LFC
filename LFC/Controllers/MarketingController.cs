using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFC.Controllers
{
    public class MarketingController : Controller
    {
        // GET: Marketing
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EmailMarketing()
        {
            return View();
        }

        public ActionResult DirectMail()
        {
            return View();
        }


    }
}