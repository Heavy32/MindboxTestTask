using SquareCalculatorFactoryVersion.Calculator.SquareCalculators.SquareCalculatorFactories;
using SquareCalculatorFactoryVersion.Figures;

namespace SquareCalculatorFactoryVersion.Calculator
{
    public class Calculator : ICalculator
    {
        private readonly ISquareCalculatorFactory squareCalculatorFactory;

        public Calculator(ISquareCalculatorFactory squareCalculatorFactory)
        {
            this.squareCalculatorFactory = squareCalculatorFactory;
        }

        public double GetSquare<TFigure>(TFigure figure) where TFigure : IFigure
        {
            return squareCalculatorFactory.Create<TFigure>().GetSquare(figure);
        }
    }
}
