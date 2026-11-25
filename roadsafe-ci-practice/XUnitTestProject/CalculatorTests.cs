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

        [Fact]
        public void SUBTRACT_TWO_NUMBERS_RETURNS_DIFFIRENCE()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Substract(-1, 1);

            Assert.Equal(0, result); // The actual result must be -2, we are intentionally failing it
        }

        [Fact]
        public void MULTIPLY_TWO_NUMBERS_RETURNS_PRODUCT()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Multiply(-1, calculator.Substract(-1, 1));

            Assert.Equal(-2, result); // The actual result must be 2, we are intentionally failing it
        }


        [Fact]
        public void DIVIDE_TWO_NUMBERS_RETURNS_DIVISONRESULT()
        {
            Calculator calculator = new Calculator();

            var result = calculator.Divide(100, 2);

            Assert.Equal(50, result);
        }

    }
}
