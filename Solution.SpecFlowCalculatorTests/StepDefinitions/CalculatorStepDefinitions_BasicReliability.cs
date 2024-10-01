using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions_BasicReliability
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorStepDefinitions_BasicReliability(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        // Step Definition for Basic Failure Intensity Calculation
        [When(@"I have entered (.*) as initial failure intensity, (.*) as average failures, and (.*) as total failures over infinite time into the calculator and press Failure Intensity")]
        public void WhenIHaveEnteredValuesForBasicFailureIntensity(double lambda0, double mu, double v0)
        {
            _result = _calculatorContext.Calculator.BasicFailureIntensity(lambda0, mu, v0);
        }

        [Then(@"the Basic failure intensity result should be ""(.*)""")]
        public void ThenTheBasicFailureIntensityResultShouldBe(string expectedResult)
        {
            Assert.That(_result, Is.EqualTo(double.Parse(expectedResult)).Within(0.01));
        }



        // Step Definition for Basic Average Number of Failures Calculation
        [When(@"I have entered (.*) as initial failure intensity, (.*) as total failures over infinite time, and (.*) as time into the calculator and press Average Failures")]
        public void WhenIHaveEnteredValuesForBasicAverageFailures(double lambda0, double v0, double tau)
        {
            _result = _calculatorContext.Calculator.BasicAverageFailures(lambda0, v0, tau);
        }

        [Then(@"the average number of failures result should be ""(.*)""")]
        public void ThenTheAverageNumberOfFailuresResultShouldBe(string expectedResult)
        {
            Assert.That(_result, Is.EqualTo(double.Parse(expectedResult)).Within(0.1));
        }

    }
}
