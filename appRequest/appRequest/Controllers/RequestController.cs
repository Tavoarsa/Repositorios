using appRequest.Filters;
using appRequest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appRequest.Controllers
{
    [Authorize]
    [InitializeSimpleMembership]
    public class RequestController : Controller
    {
        private ContextDb db = new ContextDb();
        //
        // GET: /Request/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string  name="",string urlBase="",string action="")
        {
            Request request = new Request();
            request.name = name;
            request.urlBase = urlBase;
            request.action = action;
            if (ModelState.IsValid)
            {
                db.Requests.Add(request);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
           
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
