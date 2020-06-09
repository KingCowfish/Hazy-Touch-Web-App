using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HazyTouchWebsite.ViewModels;
using System.Net.Mail;
using System.Web.Mvc;
using HazyTouchWebsite.Models;

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

        //[HttpPost]
        //public ActionResult Index(ContactViewModel vm)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            MailMessage msz = new MailMessage();
        //            msz.From = new MailAddress(vm.Email);//Email which you are getting 
        //                                                 //from contact us page 
        //            msz.To.Add("brodera146@gmail.com");//Where mail will be sent 
        //            msz.Subject = vm.Subject;
        //            msz.Body = vm.Message;
        //            SmtpClient smtp = new SmtpClient();

        //            smtp.Host = "smtp.gmail.com";

        //            smtp.Port = 587;

        //            smtp.Credentials = new System.Net.NetworkCredential
        //            ("youremailid@gmail.com", "password");

        //            smtp.EnableSsl = true;

        //            smtp.Send(msz);

        //            ModelState.Clear();
        //            ViewBag.Message = "Thank you for your interest!";
        //        }
        //        catch (Exception ex)
        //        {
        //            ModelState.Clear();
        //            ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
        //        }
        //    }

        //    return View();
        //}
        //public ActionResult Error()
        //{
        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(MessageModel model)
        {
            if (ModelState.IsValid)
            {
                var mail = new MailMessage();
                mail.To.Add(new MailAddress(model.SenderEmail));
                mail.Subject = "Your Email Subject";
                mail.Body = string.Format("<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>", model.SenderName, model.SenderEmail, model.Message);
                mail.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(mail);
                    return RedirectToAction("SuccessMessage");
                }
            }
            return View(model);
        }

        public ActionResult SuccessMessage()
        {
            return View();
        }

    }
}
