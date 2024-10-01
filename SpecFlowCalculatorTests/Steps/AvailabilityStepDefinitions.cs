using Lab02;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class UsingAvailabilityStepDefinitions
    {
        // Context Injection for SpecFlow
        private readonly Calculator _calculator;
    
        public UsingAvailabilityStepDefinitions(Calculator calc) // Constructor injection for context
        {
            this._calculator = calc; // Inject the calculator object
        }
        //--------------------------------

        private double _result;

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMtbf(double p0, double p1)
        {
            _result = _calculator.MTBF(p0, p1);
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            _result = _calculator.Availability(p0, p1);
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTTF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMttf(double p0, double p1)
        {
            _result = _calculator.MTTF(p0, p1);
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTTR")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMttr(double p0, double p1)
        {
            _result = _calculator.MTTR(p0, p1);
        }
    }
}

