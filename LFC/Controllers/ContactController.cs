using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LFC.Models;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LFC.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RenderReportContactForm()
        {
            Contact model = new Contact();
            return View(model);
        }


        [HttpPost]
        public ActionResult SendEmail(Contact contact)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress(contact.EmailAddress);

            message.To.Add(new MailAddress("leapforwardcopy@gmail.com"));

            message.Subject = string.Concat("A potential client has registered: ", contact.Subject);
            message.Body = contact.Message;

            SmtpClient client = new SmtpClient();
            client.Send(message);
            return RedirectToAction("SuccessPage", "Home");
        }

        //[HttpPost]
        //public async Task<ActionResult> SendEmail(string first_name, string last_name, string email, string phone, string address, string city,string state, string zip, string msg)
        //{

        //    await Task.Run(() =>
        //    {
        //        //MailMessage message = new MailMessage();
        //        //message.From = new MailAddress(email);

        //        //message.To.Add(new MailAddress("leapforwardcopy@gmail.com"));

        //        //message.Subject = "A potential client has registered: ";
        //        //message.Body = string.Concat("<p>First Name: ", first_name, "</p><p> Name: ", last_name, "</p><p>Email: ", email, "</p><p>Phone: ", phone, "</p><p>Address: ", address, "</p><p>City: ", city, "</p><p>State: ", state, "</p><p>Zip: ", zip, "</p><p>Message: ", msg);

        //        //SmtpClient client = new SmtpClient();
        //        //client.Send(message);
        //    });

        //    return File("~/Content/files/Sell_your_story.pdf", "application/pdf");


        //}

        
    }
}