using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appRequest.Models
{
    public class Request
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string urlBase { get; set; }
        public string httpVerb { get; set; }
        public object parameters { get; set; }

    }
}