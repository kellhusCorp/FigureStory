using AreaCalculator.Abstractions;
using AreaCalculator.Figures;

namespace AreaCalculator.Tests;

public class CircleTests : BaseTests
{
    [Test]
    [TestCase(-3d)]
    public void Test_Circle_Ctor_Throws_Argument_Exception_When_Radius_Is_Negative_Number_Or_Zero(double radius)
    {
        Assert.Throws<ArgumentException>(() =>
        {
            Figure figure = new Circle(radius);
        });
    }

    [Test]
    [TestCase(1d, 3.1415926535897931)]
    [TestCase(3d, 28.2743338823081378)]
    [TestCase(0d, 0d)] // вырожденный случай
    public void Test_Circle_GetArea_Returns_Correct_Value(double radius, double expectedValue)
    {
        Figure figure = new Circle(radius);

        var area = figure.GetArea();

        Assert.That(area, Is.EqualTo(expectedValue).Within(DefaultEpsilon));
    }
}