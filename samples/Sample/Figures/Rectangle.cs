using AreaCalculator.Abstractions;

namespace Sample.Figures;

// Пример добавления фигуры.

/// <summary>
/// Прямоугольник.
/// </summary>
public class Rectangle : Figure
{
    private readonly double width;
    private readonly double height;

    
    public Rectangle(double width, double height)
    {
        if (width < 0)
        {
            throw new ArgumentException("Ширина не может быть меньше 0");
        }

        if (height < 0)
        {
            throw new ArgumentException("Высота не может быть меньше 0");
        }
        
        this.width = width;
        this.height = height;
    }
    
    public override double GetArea()
    {
        return width * height;
    }
}