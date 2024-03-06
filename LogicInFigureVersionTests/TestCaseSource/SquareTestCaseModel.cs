using LogicInFigureVersion;

namespace LogicInFigureVersionTests.TestCaseSource
{
    public class SquareTestCaseModel<TFigure> where TFigure : ISquareCalculatedFigure
    {
        public TFigure Figure { get; init; }
        public double ExpectedSquare { get; init; }
    }
}
