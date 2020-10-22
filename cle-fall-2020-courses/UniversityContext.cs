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
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=UniversityDB_102020;Trusted_Connection=True";

            optionsBuilder.UseSqlServer(connectionString)
            .UseLazyLoadingProxies();

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
                    InstructorId = 1,
                    LastRevision = "10/18/2020"
                },

                new Course
                {
                    Id = 2,
                    Name = "C# For Anyone",
                    Description = "Bootcamp Not Needed",
                    InstructorId = 2,
                    LastRevision = "10/18/2020"

                },

                new Course
                {
                    Id = 3,
                    Name = "Front End Work",
                    Description = "Where It's At",
                    InstructorId = 2,
                    LastRevision = "10/18/2020"

                });

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor()
                {
                    Id = 1,
                    Name = "Jen"
                },

                new Instructor()
                {
                    Id = 2,
                    Name = "Andy"
                });

            modelBuilder.Entity<Student>().HasData(
                new Student()
                {
                    Id = 1,
                    Name = "Ferris Bueller"
                },

               new Student()
               {
                   Id = 2,
                   Name = "Cameron Frye"
               },

               new Student()
               {
                   Id = 3,
                   Name = "Sloane Peterson"
               });

            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse()
                {
                    Id = 1,
                    CourseId = 1,
                    StudentId = 1
                },

                new StudentCourse()
                {
                    Id = 2,
                    CourseId = 1,
                    StudentId = 2
                },

                new StudentCourse()
                {
                    Id = 3,
                    CourseId = 2,
                    StudentId = 2
                },

                new StudentCourse()
                {
                    Id = 4,
                    CourseId = 2,
                    StudentId = 3
                },

                new StudentCourse()
                {
                    Id = 5,
                    CourseId = 3,
                    StudentId = 1
                },

                new StudentCourse()
                {
                    Id = 6,
                    CourseId = 3,
                    StudentId = 3
                });

            base.OnModelCreating(modelBuilder);

        }


    }
}
