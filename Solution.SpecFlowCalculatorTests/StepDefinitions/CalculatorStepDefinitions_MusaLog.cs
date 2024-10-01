using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions_MusaLogarithmicModel
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorStepDefinitions_MusaLogarithmicModel(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        // Step Definition for Musa Logarithmic Failure Intensity Calculation
        [When(@"I have entered (.*) as initial failure intensity, (.*) as theta, and (.*) as mu into the calculator and press Failure Intensity")]
        public void WhenIHaveEnteredValuesForFailureIntensity(double lambda0, double theta, double mu)
        {
            _result = _calculatorContext.Calculator.CalculateFailureIntensity(lambda0, theta, mu);
        }

        [Then(@"the failure intensity result should be ""(.*)""")]
        public void ThenTheFailureIntensityResultShouldBe(string expectedResult)
        {
            Assert.That(_result, Is.EqualTo(double.Parse(expectedResult)).Within(0.001)); // Tolerance for precision
        }

        // Step Definition for Musa Logarithmic Expected Failures Calculation
        [When(@"I have entered (.*) as initial failure intensity, (.*) as theta, and (.*) as tau into the calculator and press Expected Failures")]
        public void WhenIHaveEnteredValuesForExpectedFailures(double lambda0, double theta, double tau)
        {
            _result = _calculatorContext.Calculator.CalculateExpectedFailures(lambda0, theta, tau);
        }

        [Then(@"the expected number of failures result should be ""(.*)""")]
        public void ThenTheExpectedNumberOfFailuresResultShouldBe(string expectedResult)
        {
            Assert.That(_result, Is.EqualTo(double.Parse(expectedResult)).Within(0.001)); // Tolerance for precision
        }
    }
}
