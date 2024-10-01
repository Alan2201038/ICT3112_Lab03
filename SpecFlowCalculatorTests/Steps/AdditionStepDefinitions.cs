using Lab02;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class UsingCalculatorAdditionSteps
    {
        private Calculator _calculator;
        private double _result;
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorForAddition(double num1, double num2)
        {
            _result = _calculator.Add(num1, num2); // Use the injected calculator
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheAdditionResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }
        
    }
    
}