using SquareCalculatorFactoryVersion.Figures;

namespace SquareCalculatorFactoryVersion.Calculator.SquareCalculators
{
    public interface ISquareCalculator<TFigure> where TFigure : IFigure
    {
        double GetSquare(TFigure figure);
    }
}
