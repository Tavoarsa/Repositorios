using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Postal;
using CurriculumApp.Models;
using System.Net;

namespace CurriculumApp.Controllers
{
    public class HomeController : Controller
    {

        private RecommendDb db = new RecommendDb();
         //
        // GET: /Home/
        
        public ActionResult Home()
        {
                       return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        

        public ActionResult Recommend()
        {

            List<Recommend> recommends = db.Recommeds.ToList();
            ViewBag.recommends = recommends;
            return View();
            
        }

        public static void SendEmail(string body="hidjd")
    {
            MailMessage mailMessage= new MailMessage("tavo.cr23@gmail.com","tavo.cr23@gmail.com");
            mailMessage.Subject="Hola";
            mailMessage.Body=body;
            SmtpClient smtpClient = new SmtpClient ("smtp.gmail.com",587);
            smtpClient.Credentials=new System.Net.NetworkCredential()
            {
                UserName="tavo.cr23@gmail.com",
                Password="mariana1234-2665735"
            };
            smtpClient.EnableSsl=true;
            smtpClient.Send(mailMessage);
    }
        

        [HttpPost]
        public ActionResult SendEmail(string name,  string email, string message)
        {

            MailMessage mail = new MailMessage();
            SmtpClient Smtp = new SmtpClient();
            mail.From = new MailAddress("tavo.cr23@gmail.com");
            //Destinatario
            mail.To.Add(new MailAddress(email));
           
            mail.Body = message;
            Smtp.Host = "smtp.gmail.com";
            Smtp.Port = 587;
            Smtp.Credentials = new System.Net.NetworkCredential("tavo.cr23@gmail.com", "mariana1234-2665735");
            Smtp.EnableSsl = true;
            Smtp.Send(mail);

            return RedirectToAction("Contact");
        }
            

        public ActionResult Create()
        {
            return View();
        }
    
    [HttpPost]
        public ActionResult Create(string nombre="",int telefono=0,string email="",string comentario="")
        {
        Recommend nueva = new Recommend();
            nueva.Nombre = nombre;
            nueva.Telefono = telefono;
            nueva.Email = email;
            nueva.Comentario = comentario;
            if (ModelState.IsValid)
            {
                db.Recommeds.Add(nueva);
                db.SaveChanges();
                return RedirectToAction("Recommend");
            }
            return View();


        }

    public ActionResult Delete(int id)
    {
        Recommend recomend = db.Recommeds.Find(id);
        if (recomend == null)
        {
            return HttpNotFound();

        }
        ViewBag.recomend = recomend;
        return View();
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        Recommend recomend = db.Recommeds.Find(id);
        db.Recommeds.Remove(recomend);
        db.SaveChanges();
        return RedirectToAction("Recommend");
    }





    protected override void Dispose(bool disposing)
    {
        db.Dispose();
        base.Dispose(disposing);
    }

               

    }
}
