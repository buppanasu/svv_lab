using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions_SSI
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorStepDefinitions_SSI(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        // Step Definition for SSI calculation
        [When(@"I have entered (.*) as previous SSI, (.*) as CSI, (.*) as deleted code, and (.*) as changed code into the calculator and press SSI")]
        public void WhenIHaveEnteredValuesForSSICalculation(double ssiPrevious, double csi, double deletedCode, double changedCode)
        {
            _result = _calculatorContext.Calculator.CalculateSSI(ssiPrevious, csi, deletedCode, changedCode);
        }

        [Then(@"the SSI result should be ""(.*)""")]
        public void ThenTheSSIResultShouldBe(string expectedResult)
        {
            Assert.That(_result, Is.EqualTo(double.Parse(expectedResult)).Within(0.001)); // Allow tolerance for floating-point precision
        }
    }
}
