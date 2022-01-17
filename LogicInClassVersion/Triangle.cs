using System;

namespace LogicInFigureVersion
{
    public sealed class Triangle : ISquareCalculatedFigure
    {
        /// <summary>
        /// Первая сторона
        /// </summary>
        public double A { get; init; }
        /// <summary>
        /// Вторая сторона
        /// </summary>
        public double B { get; init; }
        /// <summary>
        /// Третья сторона
        /// </summary>
        public double C { get; init; }

        public double Square 
        { 
            get 
            {
                double halfPerimeter = (A + B + C) / 2;
                return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
            } 
        }
    }
}
