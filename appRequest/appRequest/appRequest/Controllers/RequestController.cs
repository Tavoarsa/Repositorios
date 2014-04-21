using appRequest.Filters;
using appRequest.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
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
            int userId = (int)Membership.GetUser().ProviderUserKey;
            UserProfile usuario = db.UserProfiles.Find(userId);

            StringBuilder sql = new StringBuilder();
            sql.AppendLine("select r.Id,r.name,r.urlBase,r.action,r.httpVerb ");
            sql.AppendLine("from Request r ");
            sql.AppendLine("where  r.Usuario_UserId="+userId+"");
           

            var request = db.Database.SqlQuery<QueryRequest>(sql.ToString(),new SqlParameter("Usuario_UserId", userId)).ToList();
            ViewBag.request = request.ToList();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(string name, string urlBase, string action, string httpVerb)
        {
            
            Request request = new Request();
            int userId = (int)Membership.GetUser().ProviderUserKey;
            UserProfile usuario = db.UserProfiles.Find(userId);
            request.Usuario = usuario;
            request.name = name;
            request.urlBase = urlBase;
            request.action = action;
            request.httpVerb = httpVerb;


            if (ModelState.IsValid)
            {
                db.Requests.Add(request);
                db.SaveChanges();
                ViewBag.requestt = request;        
                            

            }

            return View();
        }
        [HttpPost]
        public ActionResult CreateP(int Id,string urlKey, string value)
        {


            Parameter parameter = new Parameter();

            Request request = db.Requests.Find(Id);

            parameter.Id_Request = request;
            parameter.UrlKey = urlKey;
            parameter.Value = value;


            if (ModelState.IsValid)
            {
                db.Parameters.Add(parameter);
                db.SaveChanges();

            }

            return View();
        }
        

        public ActionResult Edit(int id)
        {
            Request request = db.Requests.Find(id);
            if (request== null)
            {
                return HttpNotFound();
            }
            ViewBag.request =request;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(string name, string urlBase, string action, string httpVerb, int id)
        {
            if (ModelState.IsValid)
            {
                Request request = db.Requests.Find(id);
                request.name = name;
                request.urlBase = urlBase;
                request.action = action;
                request.httpVerb = httpVerb;                
                db.Entry(request).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            Request request = db.Requests.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            ViewBag.request = request;
            return View();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Request request = db.Requests.Find(id);
            db.Requests.Remove(request);
            db.SaveChanges();
            return RedirectToAction("Index");
        }      
      

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
