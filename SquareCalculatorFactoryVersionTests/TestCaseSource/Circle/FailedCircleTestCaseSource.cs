namespace LogicInFigureVersionTests.TestCaseSource.Circle
{
    public class FailedCircleTestCaseSource
    {
        public static SquareCalculatorFactoryVersion.Figures.Circle[] zeroOrLessZeroTestCircles =
        {
            new SquareCalculatorFactoryVersion.Figures.Circle {Radius = 0},
            new SquareCalculatorFactoryVersion.Figures.Circle {Radius = -5}
        };
    }
}
