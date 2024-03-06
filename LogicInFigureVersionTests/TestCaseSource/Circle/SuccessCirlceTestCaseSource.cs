namespace LogicInFigureVersionTests.TestCaseSource.Circle
{
    public class SuccessCirlceTestCaseSource
    {
        public static SquareTestCaseModel<LogicInFigureVersion.Circle>[] testCircles =
        {
            new SquareTestCaseModel<LogicInFigureVersion.Circle>
            {
                Figure = new LogicInFigureVersion.Circle { Radius = 5},
                ExpectedSquare = 78.53981633974483
            }
        };
    }
}
