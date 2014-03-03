using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CurriculumApp.Models
{
    public class RecommendDb : DbContext 
    {
        public RecommendDb() :base ("DefaultConnection")
        {

        }
        public DbSet<Recommend> Recommeds { get; set; } 
    }
}