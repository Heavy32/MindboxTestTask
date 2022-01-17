using System;

namespace SquareCalculatorFactoryVersion.Calculator.SquareCalculators.SquareCalculatorFactories
{
    public class FigureNotFoundException : Exception
    {
        public FigureNotFoundException(string message) : base(message)
        {
        }
    }
}
