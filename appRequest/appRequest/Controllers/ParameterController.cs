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

        public ActionResult Create()
        {

            return View();

        }

    }
}
