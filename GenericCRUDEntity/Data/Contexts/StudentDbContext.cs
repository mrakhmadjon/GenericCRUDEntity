using GenericCRUDEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCRUDEntity.Data.Contexts
{
    internal class StudentDbContext :DbContext
    {

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("host=localhost;port=5432;username=postgres;database=postgres;password=12345");
        }


    }
}
