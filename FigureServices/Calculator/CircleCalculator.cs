using FigureServicesVersion.Figures;
using System;

namespace FigureServicesVersion.Calculator
{
    public class CircleCalculator : ICalculator<Circle>
    {
        public double GetSquare(Circle figure)
        {
            if(figure.Radius <= 0)
            {
                throw new ArgumentException("Radius cannot be less or equal zero", nameof(figure));
            }

            return Math.Pow(figure.Radius, 2) * Math.PI;
        }
    }
}
