using Lab02;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class UsingCalculatorDivisionsSteps
    {
        // Context Injection for SpecFlow
        private readonly Calculator _calculator;
    
        public UsingCalculatorDivisionsSteps(Calculator calc) // Constructor injection for context
        {
            this._calculator = calc; // Inject the calculator object
        }
        //--------------------------------

        private double _result;

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorForDivision(double num1, double num2)
        {
            _result = _calculator.Divide(num1, num2); // Use the injected calculator
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}

