using AreaCalculator;
using AreaCalculator.Abstractions;
using AreaCalculator.Figures;
using Sample.Figures;


internal static class Program
{
    private static void Main()
    {
        var rectangle = new Rectangle(3, 4);

        var figures = GetDefaultFigures();

        foreach (var figure in figures)
        {
            Console.WriteLine(figure.GetDetailedInfo());

            //Можно было бы конечно выводить информацию о площади прямо в GetDetailedInfo(), но решил, пусть это делает вызывающий код.
            Console.WriteLine($"Площадь: {figure.GetArea()}");

            Console.WriteLine();
        }

        // Можно было бы образовать новый тип, контейнер фигур, в принципе.

        Console.WriteLine($"Общая сумма площадей фигур в контейнере = {CalculatorOfArea.GetTotalArea(figures)}");
    }

    /// <summary>
    /// Возвращает коллекцию фигур.
    /// </summary>
    /// <returns></returns>
    private static IEnumerable<Figure> GetDefaultFigures()
    {
        return new Figure[]
        {
            new Circle(3d),
            new Circle(5d),
            new Triangle(3d, 4d, 5d),
            new Rectangle(2d, 10d),
            new RightTriangle(6d, 8d),
            new IsoscelesTriangle(3d, 5d),
            new EquilateralTriangle(4d)
        };
    }
}