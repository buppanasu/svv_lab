using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions_Availability
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorStepDefinitions_Availability(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double totalUptime, int failures)
        {
            _result = _calculatorContext.Calculator.MTBF(totalUptime, failures);
        }

        [Then(@"the MTBF result should be ""(.*)""")]
        public void ThenTheMTBFResultShouldBe(string expectedResult)
        {
            if (expectedResult == "Infinity")
            {
                Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
            }
            else
            {
                Assert.That(_result, Is.EqualTo(double.Parse(expectedResult)));
            }
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double mtbf, double mttr)
        {
            _result = _calculatorContext.Calculator.Availability(mtbf, mttr);
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(string expectedResult)
        {
            double expectedValue = double.Parse(expectedResult);
            Assert.That(_result, Is.EqualTo(expectedValue).Within(0.001)); // Allow a tolerance of 0.001
        }
    }
}
