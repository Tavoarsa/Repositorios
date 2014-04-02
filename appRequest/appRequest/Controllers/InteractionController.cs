using appRequest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appRequest.Controllers
{
    public class InteractionController : Controller
    {

        private ContextDb db = new ContextDb();
        //
        // GET: /Interaction/

        public ActionResult Index()
        {
            List<Interaction> interaction = db.Interactions.ToList();
            ViewBag.interactions = interaction;        
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Parameter parameter)
        {
            Interaction newInteraction = new Interaction();
            newInteraction.Parameter = parameter;
            if (ModelState.IsValid)
            {
                db.Interactions.Add(newInteraction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult Edit()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed()
        {
            return View();

        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
