using Lab02;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class UsingReliabilityStepDefinitions
    {
        // Context Injection for SpecFlow
        private readonly Calculator _calculator;
    
        public UsingReliabilityStepDefinitions(Calculator calc) // Constructor injection for context
        {
            this._calculator = calc; // Inject the calculator object
        }
        //--------------------------------

        private double _result;

        [When(@"I have entered (.*) , (.*) and (.*) into the calculator and press CFIBasic")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCfi(double p0, double p1, double p2)
        {
            _result = _calculator.CFIBasic(p0, p1, p2);
        }

        [Then(@"the reliability result should be (.*)")]
        public void ThenTheReliabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) , (.*) and (.*) into the calculator and press CFILog")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCfiLog(double p0, double p1, double p2)
        {
            _result = _calculator.CFILog(p0, p1, p2);
        }

        [When(@"I have entered (.*) , (.*) and (.*) into the calculator and press AEFBasic")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAefBasic(double p0, double p1, double p2)
        {
            _result = _calculator.AEFBasic(p0, p1, p2);
        }

        [When(@"I have entered (.*) , (.*) and (.*) into the calculator and press AEFLog")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAefLog(double p0, double p1, double p2)
        {
            _result = _calculator.AEFLog(p0, p1, p2);
        }
    }
}