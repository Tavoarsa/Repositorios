using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace appRequest.Models
{
    [Table("Parameter")]
    public class Parameter
    {
        public int Id{get; set; }
        public int Id_Request { get; set; }
        public string UrlKey { set; get; }
        public string Values { get; set; }
    }
}