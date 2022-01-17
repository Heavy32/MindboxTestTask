using System;

namespace LogicInFigureVersion
{
    public sealed class Circle : ISquareCalculatedFigure
    {
        public double Radius { get; init; }
        public double Square => Math.Pow(Radius, 2) * Math.PI;
    }
}
