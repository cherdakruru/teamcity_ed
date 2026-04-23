using Xunit;

namespace TeamCityDemo.Tests;

public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [Fact]
    public void Add_ShouldReturnSum()
    {
        var result = _calc.Add(5, 3);
        Assert.Equal(8, result);
    }

    [Fact]
    public void Subtract_ShouldReturnDifference()
    {
        var result = _calc.Subtract(10, 4);
        Assert.Equal(6, result);
    }
    
    // Этот тест упадёт, если раскомментировать
    // [Fact]
    // public void FailingTest_ForCI() => Assert.True(false);
}