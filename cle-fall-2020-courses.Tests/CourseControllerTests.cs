using cle_fall_2020_courses.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace cle_fall_2020_courses.Tests
{
    public class CourseControllerTests
    {
        [Fact]
        public void Index_Returns_A_View()
        {
            // Arrange
            CourseController sut = new CourseController();

            // Act
            var result = sut.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}