using SquareCalculatorFactoryVersion.Figures;

namespace SquareCalculatorFactoryVersion.Calculator.SquareCalculators.SquareCalculatorFactories
{
    public interface ISquareCalculatorFactory
    {
        ISquareCalculator<TFigure> Create<TFigure>() where TFigure : IFigure;
    }
}
