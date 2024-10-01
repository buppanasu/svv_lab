namespace ICT3101_Calculator.UnitTests;

public class CalculatorTests
{
    private Calculator _calculator;
    private FileReader _fileReader;
    [SetUp]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();
        _fileReader = new FileReader();
    }
    [Test]
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        // Act
        double result = _calculator.Add(10, 20);
        // Assert
        Assert.That(result, Is.EqualTo(30));
    }

    [Test]
    public void Subtract_WhenSubtractingTwoNumbers_Result_EqualToSubraction()
    {
        // Act
        double result = _calculator.Subtract(20, 10);

        // Assert
        Assert.That(result, Is.EqualTo(10));



    }

    [Test]
    public void Multiply_WhenMultiplyingTwoNumbers_Result_EqualToMultiplication()
    {

        //Act
        double result = _calculator.Multiply(10, 10);

        // Assert
        Assert.That(result, Is.EqualTo(100));

    }

    [Test]
    public void Divide_WhenDividingTwoNumbers_Result_EqualToDivision()
    {

        //Act
        double result = _calculator.Divide(10, 2);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }



    // 15. Now add a new function for calculating a Factorial and write the corresponding Unit tests. (The Whitebox Testing lectures have an example of this function that you can use)
    [Test]
    [TestCase(0)]
    public void Factorial_FactorialWithZeroAsInput_ResultEqualToOne(double a)
    {
        // Act
        double result = _calculator.Factorial(0);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    [TestCase(1)]
    public void Factorial_FactorialWithOneAsInput_Result_EqualToOne(double a)
    {
        // Act
        double result = _calculator.Factorial(1);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    [TestCase(-1)]
    public void Factorial_FactorialWithNegativeInput_ThrowArgumentExceptionError(double a)
    {

        // Assert
        Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);

    }

    [Test]
    [TestCase(2, 3)]
    public void GetArea_WhenGettingAreaOfTriangle_ResultEqualToAreaOfTriangle(double a, double b)
    {
        // Act
        double result = (0.5 * _calculator.Multiply(a, b));

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    [TestCase(5, 0)]
    [TestCase(0, 5)]
    [TestCase(0, 0)]
    [TestCase(-1, -1)]
    public void GetTriangleArea_WhenGettingAreaOfTriangleHasNonPositiveInput_ResultEqualToArgumentException(double a, double b)
    {

        // Assert
        Assert.That(() => _calculator.getTriangleArea(a, b), Throws.ArgumentException);
    }

    [Test]
    [TestCase(3)]
    public void GetCircleArea_WhenGettingAreaOfCircle_ResultEqualToAreaOfCicle(double a)
    {

        // Act
        double result = _calculator.getCircleArea(a);

        // Assert 
        Assert.That(result, Is.EqualTo(28.27));
    }

    [Test]
    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(-30)]
    public void GetCircleArea_WhenGettingAreaOfCircleRadiusIsNonPositiveInput_ResultThrowsArgumentException(double a)
    {

        // Assert
        Assert.That(() => _calculator.getCircleArea(a), Throws.ArgumentException);
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest0_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest1_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest2_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(60));
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
    }

    [Test]
    public void UnknownFunctionB_WhenGivenTest0_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest1_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest2_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
    }

    // Positive test case
    [Test]
    public void GenMagicNum_ValidInput_ReturnsCorrectValue()
    {
        // Arrange: MagicNumbers.txt has at least [5, 7, 9]
        double input = 2; // This corresponds to the 3rd value in the file (index 2)

        // Act
        double result = _calculator.GenMagicNum(input);

        // Assert
        Assert.That(result, Is.EqualTo(18)); // (9 * 2 = 18)
    }

    // Negative test case
    [Test]
    public void GenMagicNum_NegativeInput_ReturnsNegativeValue()
    {
        // Arrange
        double input = -1;

        // Act
        double result = _calculator.GenMagicNum(input);

        // Assert
        Assert.That(result, Is.EqualTo(-0)); // Returns -0 as expected for negative inputs
    }

    // Exceptional case test (out of range)
    [Test]
    public void GenMagicNum_InputOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange: Assume MagicNumbers.txt has only 3 values (e.g., 5, 7, 9)
        double input = 5; // This index is out of range for a file with 3 values

        // Act and Assert
        Assert.Throws<IndexOutOfRangeException>(() => _calculator.GenMagicNum(input));
    }






}


// 10 .We have copied and pasted the Calculator Unit Test Code. We have also added the ICT3101_Calculator project to the dependencies of this testing project
// 10. To add the dependency we have to run this command: dotnet add reference /Users/junjie/SVV_Module/ICT1301_Calculator/ICT1301_Calculator.csproj
// 11. As you will notice in the Unit test, we follow the naming convention of "MethodNameWe'reTesting_ScenarioWe'reTesting_ExpectedBehaviorOrResult".
// 11. We also use the NUnit Prefix of "[Test]" to denote a Unit test
// 11. Also note we're using the "[Setup]" prefix. This causes the following function to get called before any test in this class executes -- The convention is to name the method [setup]
// 11. Now to check that this runs okay, open 'Test Explorer' or just right-click on your UnitTests project, and then select 'Run Tests'
// 11. My Test Explorer shortcut is:  Cmd + Shift + P --> Type Show Testing --> Need to build Unit Test Project in Solution Explorer first

// Test
// Boundary test, limit of the system
// artificially limit the range of certain values
// what if other symbols come in, does it correupt your data
// just whack the system - arthur (basically limit testing)