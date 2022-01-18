namespace LogicInFigureVersionTests.TestCaseSource.Triangle
{
    public class SuccessTriangleTestCaseSource
    {
        public static SquareTestCaseModel<LogicInFigureVersion.Triangle>[] testTriangles =
        {
            new SquareTestCaseModel<LogicInFigureVersion.Triangle>
            {
                Figure = new LogicInFigureVersion.Triangle { A = 3, B = 4, C = 5},
                ExpectedSquare = 6
            }
        }; 
    }
}
