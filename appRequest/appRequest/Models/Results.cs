using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace appRequest.Models
{
    [Table("Results")]
    public class Results
    {
        public int Id { get; set; }
        public Interaction Id_Interaction { get; set; }
        public string Response { get; set; }
    }
}