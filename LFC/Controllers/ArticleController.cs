using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LFC.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSalesCopy()
        {
            return View();
        } // GET: Article/Details/5

        public ActionResult GetNewsCopyLinks()
        {
            return View();
        }

        public ActionResult BeyondTheGame()
        {
            return View();
        }

        public ActionResult GetHopeCenter()
        {
            return View();
        }

        public ActionResult GetSpaceCenter()
        {
            return View();
        }



    }
}
