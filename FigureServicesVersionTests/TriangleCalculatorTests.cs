using FigureServicesVersion.Calculator;
using FigureServicesVersion.Figures;
using FigureServicesVersionTests.TestCaseSource.Triangle;
using NUnit.Framework;
using System;

namespace FigureServicesVersionTests
{
    public class TriangleCalculatorTests
    {
        private TriangleCalculator triangleCalculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            triangleCalculator = new();
        }

        [TestCaseSource(typeof(FaliedTriangleTestCaseSource), nameof(FaliedTriangleTestCaseSource.zeroOrLessZeroTestCircles))]
        public void ZeroOrLessZeroTriangles_ThrowsException(Triangle triangle)
        {
            //Assert
            Assert.Throws<ArgumentException>(() => triangleCalculator.GetSquare(triangle));
        }

        [TestCaseSource(typeof(SuccessTriangleTestCaseSource), nameof(SuccessTriangleTestCaseSource.testTriangles))]
        public void ValidTriangles_Success(SquareTriangleTestCaseModel caseModel)
        {
            //Arrange
            double expectedSquare = caseModel.ExpectedSquare;

            //Action
            double actualSquare = triangleCalculator.GetSquare(caseModel.Triangle);

            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }
    }
}
