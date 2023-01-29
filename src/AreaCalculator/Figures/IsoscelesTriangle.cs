using System;

namespace AreaCalculator.Figures
{
    /// <summary>
    /// Равнобедренный треугольник.
    /// </summary>
    public class IsoscelesTriangle : Triangle
    {
        /// <summary>
        /// Инстанцирует равнобедренный треугольник.
        /// </summary>
        /// <param name="side">Сторона А.</param>
        /// <param name="base">Основание треугольника.</param>
        public IsoscelesTriangle(double side, double @base) : base(side, side, @base)
        {
        }

        public override double GetArea()
        {
            return c / 4 * Math.Sqrt(4 * a * a - c * c);
        }
    }
}