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

        public ActionResult Create()
        {
            /*Request request = db.Requests.Find(Id);
            ViewBag.request = request;*/
            return View();
        }
        [HttpPost]
        public ActionResult Create(string  name,string urlBase,string action,string httpVerb,string urlKey, string Value)
        {
            QueryRequestParameter rp = new QueryRequestParameter();
            rp.request.name = name;
            rp.request.urlBase = urlBase;
            rp.request.action = action;
            rp.request.httpVerb = httpVerb;
            rp.parameter.UrlKey = urlKey;
            rp.parameter.Value = Value;
           
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
