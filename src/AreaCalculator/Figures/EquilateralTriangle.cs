using System;

namespace AreaCalculator.Figures
{
    /// <summary>
    /// Равносторонний треугольник.
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        /// <summary>
        /// Конструктор по-умолч.
        /// </summary>
        /// <param name="side">Сторона А.</param>
        public EquilateralTriangle(double side) : base(side, side, side)
        {
        }

        public override double GetArea()
        {
            return Math.Sqrt(3) * a * a / 4d;
        }
    }
}