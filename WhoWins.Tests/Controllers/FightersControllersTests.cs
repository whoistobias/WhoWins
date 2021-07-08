using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhoWins.Api.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace WhoWins.Tests.Controllers
{
    [TestClass]
    public class FightersControllersTests
    {
        [TestMethod]
        public void FightersController_GetFighters_ReturnsAListOfFighters()
        {
            // Arrange
            var logger = new Mock<ILogger<FightersController>>();
            var controller = new FightersController(logger.Object);
            // Act
            var result = controller.GetFighters();
            // Assert
            CollectionAssert.AreEqual(new[] { "Batman", "Superman" }, result.ToList());
        }
    }
}