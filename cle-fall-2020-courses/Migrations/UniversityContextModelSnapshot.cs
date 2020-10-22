﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cle_fall_2020_courses;

namespace cle_fall_2020_courses.Migrations
{
    [DbContext(typeof(UniversityContext))]
    partial class UniversityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cle_fall_2020_courses.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("LastRevision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A.I. For Humans",
                            InstructorId = 1,
                            LastRevision = "10/18/2020",
                            Name = "A.I."
                        },
                        new
                        {
                            Id = 2,
                            Description = "Bootcamp Not Needed",
                            InstructorId = 2,
                            LastRevision = "10/18/2020",
                            Name = "C# For Anyone"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Where It's At",
                            InstructorId = 2,
                            LastRevision = "10/18/2020",
                            Name = "Front End Work"
                        });
                });

            modelBuilder.Entity("cle_fall_2020_courses.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Jen"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Andy"
                        });
                });

            modelBuilder.Entity("cle_fall_2020_courses.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ferris Bueller"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cameron Frye"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sloane Peterson"
                        });
                });

            modelBuilder.Entity("cle_fall_2020_courses.Models.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 3,
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("cle_fall_2020_courses.Models.Course", b =>
                {
                    b.HasOne("cle_fall_2020_courses.Models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cle_fall_2020_courses.Models.StudentCourse", b =>
                {
                    b.HasOne("cle_fall_2020_courses.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cle_fall_2020_courses.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
