using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DotNetMEFCodeFirst.Model
{
    public class SchoolContext : System.Data.Entity.DbContext
    {

        public SchoolContext() : base("name=SchoolContextDB")
        {
        }

        public System.Data.Entity.DbSet<Student> Students { get; set; }

        public System.Data.Entity.DbSet<Course> Courses { get; set; }
    }
}
