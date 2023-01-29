using AreaCalculator.Abstractions;
using AreaCalculator.Figures;

namespace AreaCalculator.Tests;

public class AreaCalculatorTests : BaseTests
{
    [Test]
    public void Test_AreaCalculator_GetTotalArea()
    {
        var figures = new List<Figure>
        {
            new Circle(3d),
            new Triangle(3d, 4d, 5d),
            new EquilateralTriangle(3d)
        };

        var totalArea = AreaCalculator.GetTotalArea(figures);
        
        Assert.That(totalArea, Is.EqualTo(38.1714478823081379).Within(1E-5));
    }

    [Test]
    public void Test_AreaCalculator_GetTotalArea_Returns_0_When_Figure_Collection_Is_Empty()
    {
        var figures = new List<Figure>();

        var totalArea = AreaCalculator.GetTotalArea(figures);
        
        Assert.That(totalArea, Is.EqualTo(0d).Within(DefaultEpsilon));
    }
}