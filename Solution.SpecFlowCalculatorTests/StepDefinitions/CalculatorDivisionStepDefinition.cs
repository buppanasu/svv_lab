using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;   // For SpecFlow attributes like [Given], [When], [Then]

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions_Divide
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorStepDefinitions_Divide(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double value1, double value2)
        {
            _result = _calculatorContext.Calculator.Divide(value1, value2);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult));
        }

        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
