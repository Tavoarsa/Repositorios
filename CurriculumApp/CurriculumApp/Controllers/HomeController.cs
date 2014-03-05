using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Postal;
using CurriculumApp.Models;

namespace CurriculumApp.Controllers
{
    public class HomeController : Controller
    {

        private RecommendDb db = new RecommendDb();
         //
        // GET: /Home/
        
        public ActionResult Home()
        {
            /*dynamic email = new Email("Example");
            email.To = "webninja@example.com";
            email.FunnyLink = db.GetRandomLolcatLink();
            email.Send();*/
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
