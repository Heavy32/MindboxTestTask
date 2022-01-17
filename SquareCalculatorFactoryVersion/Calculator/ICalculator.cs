using SquareCalculatorFactoryVersion.Figures;

namespace SquareCalculatorFactoryVersion.Calculator
{
    public interface ICalculator
    {
        double GetSquare<T>(T figure) where T : IFigure;
    }
}
