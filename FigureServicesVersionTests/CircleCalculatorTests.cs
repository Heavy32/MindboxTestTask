using FigureServicesVersion.Calculator;
using FigureServicesVersion.Figures;
using FigureServicesVersionTests.TestCaseSource.Circle;
using NUnit.Framework;
using System;

namespace FigureServicesVersionTests
{
    public class CircleCalculatorTests
    {
        private CircleCalculator circleCalculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            circleCalculator = new();
        }

        [TestCaseSource(typeof(FailedCircleTestCaseSource), nameof(FailedCircleTestCaseSource.ZeroOrLessZeroTestCircles))]
        public void ZeroOrLessZeroCircles_ThrowsException(Circle circle)
        {
            //Assert
            Assert.Throws<ArgumentException>(() => circleCalculator.GetSquare(circle));
        }

        [TestCaseSource(typeof(SuccessCircleTestCaseSource), nameof(SuccessCircleTestCaseSource.TestCircles))]
        public void ValidCircles_Success(SquareCircleTestCaseModel caseModel)
        {
            //Arrange
            double expectedSquare = caseModel.ExpectedSquare;

            //Action
            double actualSquare = circleCalculator.GetSquare(caseModel.Circle);

            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }
    }
}