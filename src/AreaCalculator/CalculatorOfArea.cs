using System;
using System.Collections.Generic;
using System.Linq;
using AreaCalculator.Abstractions;

namespace AreaCalculator
{
    // Не любитель статики, но, пусть будет так.
    
    /// <summary>
    /// Помощник для расчета площадей фигур.
    /// </summary>
    public static class CalculatorOfArea
    {
        /// <summary>
        /// Возвращает площадь фигуры.
        /// </summary>
        /// <param name="figure">Фигура, для которой необходимо рассчитать площадь.</param>
        /// <returns></returns>
        public static double GetArea(Figure figure)
        {
            if (figure == null)
            {
                throw new ArgumentNullException(nameof(figure));
            }
            
            return figure.GetArea();
        }

        /// <summary>
        /// Возвращает суммарную площадь всех фигур.
        /// </summary>
        /// <param name="figures">Коллекция фигур.</param>
        /// <returns></returns>
        public static double GetTotalArea(IEnumerable<Figure> figures)
        {
            return figures.Sum(figure => figure.GetArea());
        }
    }
}