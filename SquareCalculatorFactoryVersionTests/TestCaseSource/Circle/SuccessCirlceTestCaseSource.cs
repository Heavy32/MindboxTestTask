namespace LogicInFigureVersionTests.TestCaseSource.Circle
{
    public class SuccessCirlceTestCaseSource
    {
        public static SquareTestCaseModel<SquareCalculatorFactoryVersion.Figures.Circle>[] testCircles =
        {
            new SquareTestCaseModel<SquareCalculatorFactoryVersion.Figures.Circle>
            {
                Figure = new SquareCalculatorFactoryVersion.Figures.Circle { Radius = 5},
                ExpectedSquare = 78.53981633974483
            }
        };
    }
}
