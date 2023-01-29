using System;
using AreaCalculator.Abstractions;
using AreaCalculator.Exceptions;
using AreaCalculator.Helpers;

namespace AreaCalculator.Figures
{
    /// <summary>
    /// Главный треугольник.
    /// </summary>
    public class Triangle : Figure
    {
        public override string Name => "Треугольник";

        protected readonly double a;
        protected readonly double b;
        protected readonly double c;

        /// <summary>
        /// Инстанцирует треугольник.
        /// </summary>
        /// <param name="a">Сторона А.</param>
        /// <param name="b">Сторона B.</param>
        /// <param name="c">Сторона C.</param>
        /// <exception cref="ArgumentException">
        /// будет выброшено, если одна из сторон отрицательна.
        /// </exception>
        /// <exception cref="TriangleNotExistsException"></exception>
        /// будет выброшено, если треугольник с данными сторонам не существует.
        public Triangle(double a, double b, double c)
        {
            if (a < 0d)
            {
                throw ThrowHelper.SideValueIsNegative(nameof(a));
            }

            if (b < 0d)
            {
                throw ThrowHelper.SideValueIsNegative(nameof(b));
            }

            if (c < 0d)
            {
                throw ThrowHelper.SideValueIsNegative(nameof(c));
            }

            if (a + b < c || b + c < a || c + a < b)
            {
                throw ThrowHelper.TriangleDoesNotExist();
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// Возвращает признак того, что треугольник является прямоугольным.
        /// </summary>
        public bool IsRight => DoubleHelper.AboutEqual(a * a + b * b, c * c);

        public override double GetArea()
        {
            double halfOfPerimeter = (a + b + c) / 2d;

            return Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - a) * (halfOfPerimeter - b) * (halfOfPerimeter - c));
        }

        private static class ThrowHelper
        {
            // В идеале можно и свой эксепшн реализовать.
            public static ArgumentException SideValueIsNegative(string sideName) =>
                new ArgumentException("Значение стороны меньше нуля.", sideName);

            public static TriangleNotExistsException TriangleDoesNotExist() => new TriangleNotExistsException();
        }

        public override string GetDetailedInfo()
        {
            return base.GetDetailedInfo() +
                   string.Join(Environment.NewLine, GetSideInfo(nameof(a), a), GetSideInfo(nameof(b), b), GetSideInfo(nameof(c), c));
        }

        private static string GetSideInfo(string sideName, double value)
        {
            return $"Сторона {sideName} = {value}";
        }
    }
}