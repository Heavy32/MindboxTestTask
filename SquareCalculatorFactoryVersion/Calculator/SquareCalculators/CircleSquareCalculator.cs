using SquareCalculatorFactoryVersion.Figures;
using System;

namespace SquareCalculatorFactoryVersion.Calculator.SquareCalculators
{
    public class CircleSquareCalculator : ISquareCalculator<Circle>
    {
        public double GetSquare(Circle figure)
        {
            return Math.Pow(figure.Radius, 2) * Math.PI;
        }
    }
}
