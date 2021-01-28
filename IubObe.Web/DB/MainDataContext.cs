
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

        
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<PLO> PLOs { get; set; }
        public DbSet<CO> COs { get; set; }
        public DbSet<Facult> Facultie { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enroll> Enrolls { get; set; }
        public DbSet<Answer> Answers { get; set; }




    }
}