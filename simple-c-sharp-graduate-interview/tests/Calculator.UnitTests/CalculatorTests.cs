using Xunit;

namespace Calculator.UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void Do_something()
        {
           var calculator = new Calculator();
           
           var something = calculator.DoSomething();
           
           Assert.Equal("does something", something);
        }
    }
}
