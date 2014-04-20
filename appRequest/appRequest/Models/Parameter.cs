using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace appRequest.Models
{
    [Table("Parameter")]
    public class Parameter
    {
        public int Id{get;set;}
        public Request Id_Request{get;set;}
        public string UrlKey{get;set;}
        public string Value{get;set;}
        [ForeignKey("Id")]
        public Request Request { get; set; }
        public IEnumerable<SelectListItem> requestList { get; set; }
        


    }
}