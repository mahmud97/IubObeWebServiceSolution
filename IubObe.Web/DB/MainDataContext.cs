
using IubObe.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IubObe.Web.DB
{
    public class MainDataContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        
    }
}