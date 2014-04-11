using appRequest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appRequest.Controllers
{
    public class ParameterController : Controller
    {

        private ContextDb db = new ContextDb();
        //
        // GET: /Parameter/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int id_request=0,string urlKey="",string value="")
        {
            Parameter parameter = new Parameter();
            parameter.Id_Request = id_request;
            parameter.UrlKey = urlKey;
            parameter.Values = value;
            if (ModelState.IsValid)
            {
                db.Parameters.Add(parameter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }

    }
}
