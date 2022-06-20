using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace EMP_Project.Models

{
    public class StudentDataContext:DbContext
    {
      public DbSet<Student> Students { get; set; }
        protected override  void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStr.ConnectionString);
        }





    }
}
