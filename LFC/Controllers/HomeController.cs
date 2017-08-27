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
        public void SendEmail(Contact contact) 
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(contact.EmailAddress);

            message.To.Add(new MailAddress("leapforwardcopy@gmail.com"));

            message.Subject = contact.Subject;
            message.Body = contact.Message;

            SmtpClient client = new SmtpClient();
            client.Send(message);
        }
    }
}