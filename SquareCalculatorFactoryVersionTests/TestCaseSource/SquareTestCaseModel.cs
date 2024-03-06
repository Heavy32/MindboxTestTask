using LogicInFigureVersion;
using SquareCalculatorFactoryVersion.Figures;

namespace LogicInFigureVersionTests.TestCaseSource
{
    public class SquareTestCaseModel<TFigure> where TFigure : IFigure
    {
        public TFigure Figure { get; init; }
        public double ExpectedSquare { get; init; }
    }
}
