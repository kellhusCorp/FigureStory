using System;

namespace AreaCalculator.Figures
{
    /// <summary>
    /// Равносторонний треугольник.
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        public override string Name => "Равносторонний треугольник";

        /// <summary>
        /// Инстанцирует равносторонний треугольник.
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