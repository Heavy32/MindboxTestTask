using SquareCalculatorFactoryVersion.Figures;
using System;

namespace SquareCalculatorFactoryVersion.Calculator.SquareCalculators
{
    public sealed class TriangleSquareCalculator : ISquareCalculator<Triangle>
    {
        public double GetSquare(Triangle figure)
        {
            double halfPerimeter = (figure.A + figure.B + figure.C) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - figure.A) * (halfPerimeter - figure.B) * (halfPerimeter - figure.C));
        }
    }
}
