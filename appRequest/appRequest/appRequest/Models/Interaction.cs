using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace appRequest.Models
{
    [Table("Interaction")]
    public class Interaction
    {
        public int Id{ get; set; }
        public Request Id_Request { get; set;}
        public string Response { get; set; }
    }
}