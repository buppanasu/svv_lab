using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions_Factorial
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorStepDefinitions_Factorial(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [When(@"I have entered (.*) into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int value)
        {
            _result = _calculatorContext.Calculator.Factorial(value);
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheFactorialResultShouldBe(double expectedResult)
        {
            Assert.That(_result, Is.EqualTo(expectedResult));
        }
    }
}
