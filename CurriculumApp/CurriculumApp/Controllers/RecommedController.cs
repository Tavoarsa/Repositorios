using CurriculumApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CurriculumApp.Controllers
{
    public class RecommedController : Controller
    {

        private RecommendDb db = new RecommendDb();
        //
        // GET: /Recommed/

        public ActionResult Index()
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
                return RedirectToAction("Index");
            }
            return View();

        }

    }
}
