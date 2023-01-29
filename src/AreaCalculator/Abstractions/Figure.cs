namespace AreaCalculator.Abstractions
{
    /// <summary>
    /// Абстракция геометрической фигуры.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Возвращает площадь фигуры.
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();
    }
}