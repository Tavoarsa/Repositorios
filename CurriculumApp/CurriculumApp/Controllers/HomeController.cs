using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Postal;

namespace CurriculumApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
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
            return View();
        }

               

    }
}
