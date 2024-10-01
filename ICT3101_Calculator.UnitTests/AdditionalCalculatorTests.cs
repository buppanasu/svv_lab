using Moq;
using NUnit.Framework;
using System;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        // Private properties for Calculator and Mock<IFileReader>
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            // Arrange: create an instance of the Calculator
            _calculator = new Calculator();

            // Create a mock for the IFileReader interface
            _mockFileReader = new Mock<IFileReader>();

            // Setup the mock to return a specific string array when any path is passed
            _mockFileReader.Setup(fr => fr.Read(It.IsAny<string>())).Returns(new string[] { "42", "42" });
        }

        // public void Setup()
        // {
        //     // Arrange: create an instance of the Calculator
        //     _calculator = new Calculator();

        //     // Create a mock for the IFileReader interface
        //     _mockFileReader = new Mock<IFileReader>();

            

        //     // Setup the mock to return a specific string array when "MagicNumbers.txt" is passed
        //     _mockFileReader.Setup(fr => fr.Read("MagicNumbers.txt")).Returns(new string[] { "42", "42" });
        // }

        // Positive test case
        [Test]
        public void GenMagicNum_ValidInput_ReturnsCorrectValue()
        {
            // Arrange: input corresponds to the 1st value (42) in the array
            double input = 0;

            // Act: pass in the _mockFileReader.Object
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object);

            // Assert: the expected value is 42 * 2 = 84
            Assert.That(result, Is.EqualTo(84));
        }

        // Negative test case
        [Test]
        public void GenMagicNum_NegativeInput_ReturnsNegativeValue()
        {
            // Arrange: input is negative
            double input = -1;

            // Act: pass in the _mockFileReader.Object
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object);

            // Assert: expect -0 as per the test case requirement
            Assert.That(result, Is.EqualTo(-0));
        }

        // Exceptional case test (out of range)
        [Test]
        public void GenMagicNum_InputOutOfRange_ThrowsIndexOutOfRangeException()
        {
            // Arrange: input is 5, but the mock only returns 2 values (index 0, 1)
            double input = 5;

            // Act & Assert: expect an IndexOutOfRangeException when the input is out of range
            Assert.Throws<IndexOutOfRangeException>(() => _calculator.GenMagicNum(input, _mockFileReader.Object));
        }
    }
}
