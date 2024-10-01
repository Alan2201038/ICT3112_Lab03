using Lab02;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps
{
    [Binding]
    public sealed class DefectDensityStepDefinitions
    {
        // Context Injection for SpecFlow
        private readonly Calculator _calculator;
    
        public DefectDensityStepDefinitions(Calculator calc) // Constructor injection for context
        {
            this._calculator = calc; // Inject the calculator object
        }
        //--------------------------------

        private double _result;

        [When(@"I have entered (.*) and (.*) into the calculator and press DD")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDd(double p0, double p1)
        {
            _result = _calculator.DD(p0, p1);
        }

        [Then(@"the defectdensity result should be (.*)")]
        public void ThenTheDefectdensityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I have a entered (.*) , (.*) and (.*) into the calculator and press SSI")]
        public void WhenIHaveAEnteredAndIntoTheCalculatorAndPressSsi(double p0, double p1, double p2)
        {
            _result = _calculator.SSI(p0, p1, p2);
        }
    }
}