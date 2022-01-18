using FigureServicesVersion.Figures;
using System;

namespace FigureServicesVersion.Calculator
{
    public class TriangleCalculator : ICalculator<Triangle>
    {
        public double GetSquare(Triangle figure)
        {
            if(figure.A <= 0 || figure.B <= 0 || figure.C <= 0)
            {
                throw new ArgumentException("One of the triangle's side is less or equal zero", nameof(figure));
            }

            double halfPerimeter = (figure.A + figure.B + figure.C) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - figure.A) * (halfPerimeter - figure.B) * (halfPerimeter - figure.C));
        }
    }
}
