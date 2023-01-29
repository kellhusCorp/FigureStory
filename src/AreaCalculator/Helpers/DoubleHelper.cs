﻿using System;

namespace AreaCalculator.Helpers
{
    /// <summary>
    /// Помощник для сравнения чисел типа double.
    /// </summary>
    public static class DoubleHelper
    {
        public static bool AboutEqual(double x, double y) {
            double epsilon = Math.Max(Math.Abs(x), Math.Abs(y)) * 1E-15;
            return Math.Abs(x - y) <= epsilon;
        }
    }
}