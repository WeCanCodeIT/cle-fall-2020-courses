using cle_fall_2020_courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cle_fall_2020_courses
{
    public class UniversityContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=UniversityDB_102020;Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course()
                {
                    Id = 1,
                    Name = "A.I.",
                    Description = "A.I. For Humans",
                },

                new Course
                {
                    Id = 2,
                    Name = "C# For Anyone",
                    Description = "Bootcamp Not Needed",
                },

                new Course
                {
                    Id = 3,
                    Name = "Front End Work",
                    Description = "Where It's At",
                });

            base.OnModelCreating(modelBuilder);

        }


    }
}
