namespace FigureServicesVersionTests.TestCaseSource.Triangle
{
    public class SuccessTriangleTestCaseSource
    {
        public static SquareTriangleTestCaseModel[] testTriangles =
        {
            new SquareTriangleTestCaseModel()
            {
                Triangle = new() {A = 3, B = 4, C = 5}, 
                ExpectedSquare = 6
            }
        };
    }
}
