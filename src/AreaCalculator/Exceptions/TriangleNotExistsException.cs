using System;

namespace AreaCalculator.Exceptions
{
    public class TriangleNotExistsException : ArgumentException
    {
        public TriangleNotExistsException() : this("Треугольник не существует с данными сторонами.")
        {
        }

        public TriangleNotExistsException(string message) : base(message)
        {
        }
    }
}