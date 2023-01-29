using System;

namespace AreaCalculator.Figures
{
    // А надо ли было выделять?
    
    /// <summary>
    /// Прямоугольный треугольник.
    /// </summary>
    public class RightTriangle : Triangle
    {
        /// <summary>
        /// Инстанцирует прямоугольный треугольник.
        /// </summary>
        /// <param name="a">Катет А.</param>
        /// <param name="b">Катет B.</param>
        public RightTriangle(double a, double b) : base(a, b, Math.Sqrt(a * a + b * b))
        {
        }

        public override double GetArea()
        {
            return 0.5 * (a * b);
        }
    }
}