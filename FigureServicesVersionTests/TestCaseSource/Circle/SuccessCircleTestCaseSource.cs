namespace FigureServicesVersionTests.TestCaseSource.Circle
{
    public class SuccessCircleTestCaseSource
    {
        public static SquareCircleTestCaseModel[] TestCircles =
        {
            new SquareCircleTestCaseModel
            {
                Circle = new FigureServicesVersion.Figures.Circle {Radius = 5 },
                ExpectedSquare = 78.53981633974483
            }
        };
    }
}
