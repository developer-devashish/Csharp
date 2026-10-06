using CalculatorApp;

namespace CalculatorApp.Tests;

public class  UnitTest1
{
    [Fact]
    public void addTest()
    {
        Calculator calculator = new Calculator();
        int result = calculator.add(5, 3);
        Assert.Equal(8, result);
    }

    [Fact]
    public void subTest()
    {
        Calculator calculator = new Calculator();
        int result = calculator.sub(5, 3);
        Assert.Equal(2, result);
    }
}
