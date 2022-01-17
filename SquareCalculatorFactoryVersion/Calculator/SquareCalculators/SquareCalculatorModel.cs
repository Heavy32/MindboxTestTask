using SquareCalculatorFactoryVersion.Figures;

namespace SquareCalculatorFactoryVersion.Calculator.SquareCalculators
{
    public class SquareCalculatorModel<TFigure> where TFigure : IFigure
    {
        public TFigure Figure {  get; init; }
    }
}
