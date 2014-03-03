using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurriculumApp.Models
{
    public class Recommend
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Comentario { get; set; }
    }
}