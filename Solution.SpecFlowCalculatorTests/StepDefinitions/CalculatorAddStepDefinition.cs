using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;   // For SpecFlow attributes like [Given], [When], [Then]

namespace SpecFlowCalculatorTests.StepDefinitions
{
    // Shared context for Calculator
    public class CalculatorContext
    {
        public Calculator Calculator { get; private set; }

        public CalculatorContext()
        {
            Calculator = new Calculator();
        }
    }

    [Binding]
    public sealed class UsingCalculatorStepDefinitions_Add
    {
        private readonly CalculatorContext _calculatorContext;
        private double _result;

        public UsingCalculatorStepDefinitions_Add(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            // The calculator is already initialized in the context
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculatorContext.Calculator.Add(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
