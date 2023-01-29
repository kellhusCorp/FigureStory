using System;

namespace AreaCalculator.Exceptions
{
    /// <summary>
    /// Тип исключения для ситуации, когда треугольник не существует.
    /// </summary>
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