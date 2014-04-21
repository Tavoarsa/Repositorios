using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace appRequest.Models
{
    [Table("Request")]
    public class Request
    {
        public int Id { get; set; }
        public UserProfile Usuario { get; set; }
        public string name { get; set; }
        public string urlBase { get; set; }
        public string action { get; set; }
        public string httpVerb { get; set; }
             

    }
}