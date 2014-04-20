using appRequest.Filters;
using appRequest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

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
            List<Request> request = db.Requests.ToList();
            ViewBag.requests = request;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]    
        public ActionResult Create(int id=0)
        {

            RequestViewModel rp = new RequestViewModel();
           


            var model = new List<RequestViewModel>();
            var dbRequest = db.Parameters.Include("Request");

            foreach (Parameter c in dbRequest)
            {
                int userId = (int)Membership.GetUser().ProviderUserKey;
                UserProfile usuario = db.UserProfiles.Find(userId);
                var requestIndex = new RequestViewModel()
                {
                    Id_request=c.Request.Id,
                    Usuario=usuario,
                    name=c.Request.name,
                    urlBase=c.Request.urlBase,
                    action=c.Request.action,
                    httpVerb=c.Request.httpVerb,
                    Id_parameter=c.Id,
                    UrlKey=c.UrlKey,
                    Value=c.Value

                };
                
                
                
                model.Add(requestIndex);


            }
            return View(model);

        }
      

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
