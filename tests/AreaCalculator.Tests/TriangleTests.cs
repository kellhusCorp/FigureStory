using AreaCalculator.Abstractions;
using AreaCalculator.Exceptions;
using AreaCalculator.Figures;

namespace AreaCalculator.Tests;

public class TriangleTests : BaseTests
{
    [Test]
    public void Test_Triangle_Ctor_Throws_Argument_Exception_When_Sides_Smaller_Zero()
    {
        double sideA = -3d;
        double sideB = -2d;
        double sideC = -1d;
        
        Assert.Throws<ArgumentException>(() =>
        {
            Figure figure = new Triangle(sideA, sideB, sideC);
        });
    }
    
    [Test]
    public void Test_Triangle_Ctor_Throws_Argument_Exception_When_Any_Side_Equals_Zero()
    {
        double sideA = 3d;
        double sideB = 0d;
        double sideC = 1d;
        
        Assert.Throws<TriangleNotExistsException>(() =>
        {
            Figure figure = new Triangle(sideA, sideB, sideC);
        });
    }

    [Test]
    public void Test_Triangle_GetArea_Returns_Correct_Value()
    {
        double sideA = 2d;
        double sideB = 3d;
        double sideC = 4d;
        Figure triangle = new Triangle(sideA, sideB, sideC);

        double area = triangle.GetArea();
        
        Assert.That(area, Is.EqualTo(2.904738).Within(0.000001));
    }

    [Test]
    public void Test_Triangle_IsRight_Returns_True()
    {
        double sideA = 3d;
        double sideB = 4d;
        double sideC = 5d;
        Triangle triangle = new Triangle(sideA, sideB, sideC);

        var isRight = triangle.IsRight;

        Assert.That(isRight, Is.True);
    }

    [Test]
    public void Test_RightTriangle_GetArea_Returns_6()
    {
        double sideA = 3d;
        double sideB = 4d;
        Figure triangle = new RightTriangle(sideA, sideB);

        var area = triangle.GetArea();
        
        Assert.That(area, Is.EqualTo(6d).Within(DefaultEpsilon));
    }

    [Test]
    public void Test_EquilateralTriangle_GetArea_Returns_Correct_Value()
    {
        double side = 3d;
        Figure triangle = new EquilateralTriangle(side);

        var area = triangle.GetArea();
        
        Assert.That(area, Is.EqualTo(3.8971143170299736).Within(DefaultEpsilon));
    }

    [Test]
    public void Test_IsoscelesTriangle_GetArea_Returns_Correct_Value()
    {
        double side = 5d;
        double @base = 8d;
        Figure triangle = new IsoscelesTriangle(side, @base);

        var area = triangle.GetArea();
        
        Assert.That(area, Is.EqualTo(12d).Within(DefaultEpsilon));
    }
}