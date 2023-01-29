using System;

namespace AreaCalculator.Figures
{
    /// <summary>
    /// Прямоугольный треугольник.
    /// </summary>
    public class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b) : base(a, b, Math.Sqrt(a * a + b * b))
        {
        }

        public override double GetArea()
        {
            return 0.5 * (a * b);
        }
    }
}