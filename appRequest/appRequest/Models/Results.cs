using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appRequest.Models
{
    public class Results
    {
        public int Id { get; set; }
        public Interaction Id_Interaction { get; set; }
        public string Response { get; set; }
    }
}