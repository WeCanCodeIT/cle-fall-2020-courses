using cle_fall_2020_courses.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace cle_fall_2020_courses.Tests
{
    public class CourseTests
    {
        Course sut;

        public CourseTests()
        {
            sut = new Course(42, "Course name", "This is the course description");
        }

        [Fact]
        public void CourseConstructor_Sets_Id_On_CourseModel()
        {
            int result = sut.Id;

            Assert.Equal(42, result);
        }

        [Fact]
        public void CourseConstructor_Sets_Name_On_CourseModel()
        {
            string result = sut.Name;

            Assert.Equal("Course name", result);
        }

        [Fact]
        public void CourseConstructor_Sets_Description_On_CourseModel()
        {
            string result = sut.Description;

            Assert.Equal("This is the course description", result);
        }
    }
}
