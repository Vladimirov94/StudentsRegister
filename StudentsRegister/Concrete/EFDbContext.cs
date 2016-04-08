using StudentsRegister.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentsRegister.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}