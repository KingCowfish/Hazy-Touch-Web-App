using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HazyTouchWebsite.ViewModels;
using System.Net.Mail;
using System.Web.Mvc;

namespace HazyTouchWebsite.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View("Contact");
        }

        [HttpPost]
        public ActionResult Index(EmailViewModel vm)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(vm.Email);//Email which you are getting from contact page.
                                                          
                    msz.To.Add("brodera146@gmail.com");//Where mail will be sent 
                    msz.Subject = vm.Subject;
                    msz.Body = vm.Message;
                    SmtpClient smtp = new SmtpClient();

                    smtp.Host = "smtp.gmail.com";

                    smtp.Port = 587;

                    smtp.Credentials = new System.Net.NetworkCredential
                    ("youremailid@gmail.com", "password");

                    smtp.EnableSsl = true;

                    smtp.Send(msz);

                    ModelState.Clear();
                    ViewBag.Message = "Thank you for Contacting us ";
                }
                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }
            return View();
        }
    }
}