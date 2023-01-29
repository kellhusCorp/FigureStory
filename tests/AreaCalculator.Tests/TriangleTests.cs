using AreaCalculator.Abstractions;
using AreaCalculator.Exceptions;
using AreaCalculator.Figures;

namespace AreaCalculator.Tests;

public class TriangleTests : BaseTests
{
    [Test]
    public void Test_Triangle_Ctor_Throws_Argument_Exception_When_Sides_Smaller_Zero()
    {
        var sideA = -3d;
        var sideB = -2d;
        var sideC = -1d;

        Assert.Throws<ArgumentException>(() =>
        {
            Figure figure = new Triangle(sideA, sideB, sideC);
        });
    }

    [Test]
    public void Test_Triangle_Ctor_Throws_Argument_Exception_When_Any_Side_Equals_Zero()
    {
        var sideA = 3d;
        var sideB = 0d;
        var sideC = 1d;

        Assert.Throws<TriangleNotExistsException>(() =>
        {
            Figure figure = new Triangle(sideA, sideB, sideC);
        });
    }

    [Test]
    public void Test_Triangle_GetArea_Returns_Correct_Value()
    {
        var sideA = 2d;
        var sideB = 3d;
        var sideC = 4d;
        Figure triangle = new Triangle(sideA, sideB, sideC);

        var area = triangle.GetArea();

        Assert.That(area, Is.EqualTo(2.904738).Within(0.000001));
    }

    [Test]
    public void Test_Triangle_IsRight_Returns_True()
    {
        var sideA = 3d;
        var sideB = 4d;
        var sideC = 5d;
        var triangle = new Triangle(sideA, sideB, sideC);

        var isRight = triangle.IsRight;

        Assert.That(isRight, Is.True);
    }

    [Test]
    public void Test_RightTriangle_GetArea_Returns_6()
    {
        var sideA = 3d;
        var sideB = 4d;
        Figure triangle = new RightTriangle(sideA, sideB);

        var area = triangle.GetArea();

        Assert.That(area, Is.EqualTo(6d).Within(DefaultEpsilon));
    }

    [Test]
    public void Test_EquilateralTriangle_GetArea_Returns_Correct_Value()
    {
        var side = 3d;
        Figure triangle = new EquilateralTriangle(side);

        var area = triangle.GetArea();

        Assert.That(area, Is.EqualTo(3.8971143170299736).Within(DefaultEpsilon));
    }

    [Test]
    public void Test_IsoscelesTriangle_GetArea_Returns_Correct_Value()
    {
        var side = 5d;
        var @base = 8d;
        Figure triangle = new IsoscelesTriangle(side, @base);

        var area = triangle.GetArea();

        Assert.That(area, Is.EqualTo(12d).Within(DefaultEpsilon));
    }
}