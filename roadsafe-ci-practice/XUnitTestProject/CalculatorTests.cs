using ConsoleApp;

namespace XUnitTestProject
{
    public class CalculatorTests
    {
        [Fact]
        public void ADD_TWO_NUMBERS_RETURNS_SUM()
        {
            // Arragne

            Calculator calculator = new Calculator();

            // Act 

            var result = calculator.Add(1,2);

            // Assert

            Assert.Equal(3, result);
        }
    }
}
