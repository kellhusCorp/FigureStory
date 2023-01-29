using System;
using AreaCalculator.Abstractions;

namespace AreaCalculator.Figures
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : Figure
    {
        private readonly double radius;

        /// <summary>
        /// Конструктор по-умолч.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <exception cref="ArgumentException">
        /// <paramref name="radius"/> равен отрицательному числу. </exception>
        public Circle(double radius)
        {
            // Опустил проверку на нуль. Вырожденный случай.
            if (radius < 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом", nameof(radius));
            }
            this.radius = radius;
        }

        public override double GetArea() => Math.PI * radius * radius;
    }
}