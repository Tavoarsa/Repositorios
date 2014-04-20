using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace appRequest.Models
{
    public class ContextDb:DbContext 
    {
        public ContextDb()
            : base("DefaultConnection")
        {

        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Interaction> Interactions {get; set;}
        public DbSet<Parameter> Parameters {get; set;}
        public DbSet<Request> Requests {get; set;}
        public DbSet<Results> Results {get; set;}
    }
}