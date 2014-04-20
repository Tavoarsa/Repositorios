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
        //
        // GET: /Interaction/
        private ContextDb db = new ContextDb();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Interaction()
        {
            return View();
        }
        [HttpPost]
       
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
