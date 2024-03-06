using FigureServicesVersion.Figures;

namespace FigureServicesVersionTests.TestCaseSource.Circle
{
    public class FailedCircleTestCaseSource
    {
        public static FigureServicesVersion.Figures.Circle[] ZeroOrLessZeroTestCircles =
        {
            new FigureServicesVersion.Figures.Circle {Radius = 0},
            new FigureServicesVersion.Figures.Circle {Radius = -5}
        };
    }
}
