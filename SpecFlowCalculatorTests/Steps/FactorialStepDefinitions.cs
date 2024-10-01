using Lab02;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class UsingFactorialStepDefinitions
    {
        // Context Injection for SpecFlow
        private readonly Calculator _calculator;
    
        public UsingFactorialStepDefinitions(Calculator calc) // Constructor injection for context
        {
            this._calculator = calc; // Inject the calculator object
        }
        //--------------------------------

        private double _result;

        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(double p0)
        {
            _result = _calculator.Factorial(p0);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}