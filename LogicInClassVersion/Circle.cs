using System;

namespace LogicInFigureVersion
{
    public sealed class Circle : ISquareCalculatedFigure
    {
        public double Radius { get; init; }
        public double Square
        {
            get
            {
                if (Radius <= 0)
                {
                    throw new ArgumentException("Radius cannot be less or equal zero");
                }

                return Math.Pow(Radius, 2) * Math.PI;
            }
        }
    }
}
