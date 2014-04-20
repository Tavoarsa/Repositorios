using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appRequest.Models
{
    public class RequestViewModel
    {
        public int Id_request { get; set; }
        public UserProfile Usuario { get; set; }
        public string name { get; set; }
        public string urlBase { get; set; }
        public string action { get; set; }
        public string httpVerb { get; set; }

        public int Id_parameter { get; set; }       
        public string UrlKey { get; set; }
        public string Value { get; set; }
    }
}