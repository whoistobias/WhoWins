using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhoWins.Api;

namespace WhoWins.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        private readonly Calculator _calculator;

        public CalculatorTest()
        {
            _calculator = new Calculator();
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(-1, -1, -2)]
        public void Calculator_AddingTwoIntegers_ReturnsCorrectValue(int x, int y, int z)
        {
            // Arrange

            // Act
            int result = _calculator.Add(x, y);

            // Assert
            Assert.AreEqual(z, result, "The two values are not equal");
        }
    }
}