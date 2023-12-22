using Microsoft.AspNetCore.Mvc;
using MyWebApi.Controllers;
using MyWebApi.Models;
using System.Collections.Generic;
using Xunit;

namespace MyWebApi.Tests.Controllers
{
    public class ValuesControllerTests
    {
        [Fact]
        public void Get_ReturnsCorrectValues()
        {
            // Arrange
            var controller = new ValuesController();

            // Act
            var result = controller.Get();

            // Simulate log statement
            System.Diagnostics.Debug.WriteLine("Testing Get method...");

            // Assert
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Value>>>(result);
            var model = Assert.IsType<List<Value>>(actionResult.Value);
            Assert.Equal(2, model.Count);

            // Simulate log statement
            System.Diagnostics.Debug.WriteLine("Get method test passed.");
        }
    }
}
