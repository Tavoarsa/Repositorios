using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appRequest.Models
{
    public class Parameter
    {
        public int Id { get; set; }
        public int Id_Request { get; set; }
        public object Values { get; set; }
    }
}