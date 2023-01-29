using System;

namespace AreaCalculator.Abstractions
{
    /// <summary>
    /// Абстракция геометрической фигуры.
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Название фигуры.
        /// </summary>
        public virtual string Name => "Фигура";

        /// <summary>
        /// Возвращает площадь фигуры.
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();

        /// <summary>
        /// Возвращает информацию о фигуре.
        /// </summary>
        /// <returns></returns>
        public virtual string GetDetailedInfo()
        {
            return $"Название фигуры: {Name} {Environment.NewLine}";
        }
    }
}