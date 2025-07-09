

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("3",3)]
    [InlineData("4",4)]
    [InlineData("420",420)]
    public void CanAddASingleNumber(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }
}
