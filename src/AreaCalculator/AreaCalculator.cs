using System.Collections.Generic;
using System.Linq;
using AreaCalculator.Abstractions;

namespace AreaCalculator
{
    public static class AreaCalculator
    {
        public static double GetArea(Figure figure)
        {
            return figure.GetArea();
        }

        public static double GetTotalArea(IEnumerable<Figure> figures)
        {
            return figures.Sum(figure => figure.GetArea());
        }
    }
}