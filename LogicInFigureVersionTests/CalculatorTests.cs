using LogicInFigureVersion;
using LogicInFigureVersionTests.TestCaseSource;
using LogicInFigureVersionTests.TestCaseSource.Circle;
using LogicInFigureVersionTests.TestCaseSource.Triangle;
using NUnit.Framework;
using System;

namespace LogicInFigureVersionTests
{
    public class CalculatorTests
    {
        private Calculator calculator;
        
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            calculator = new Calculator();
        }

        [TestCaseSource(typeof(FaliedTriangleTestCaseSource), nameof(FaliedTriangleTestCaseSource.zeroOrLessZeroTestTriangle))]
        public void ZeroOrLessZeroTriangles_ThrowsException(Triangle triangle)
        {
            //Assert
            Assert.Throws<ArgumentException>(() => calculator.GetSquare(triangle));
        }

        [TestCaseSource(typeof(SuccessTriangleTestCaseSource), nameof(SuccessTriangleTestCaseSource.testTriangles))]
        public void ValidTriangles_Success(SquareTestCaseModel<Triangle> caseModel)
        {
            //Arrange
            double expectedSquare = caseModel.ExpectedSquare;

            //Action
            double actualSquare = calculator.GetSquare(caseModel.Figure);

            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }

        [TestCaseSource(typeof(FailedCircleTestCaseSource), nameof(FailedCircleTestCaseSource.zeroOrLessZeroTestCircles))]
        public void ZeroOrLessZeroCircles_ThrowsException(Circle circle)
        {
            //Assert
            Assert.Throws<ArgumentException>(() => calculator.GetSquare(circle));
        }

        [TestCaseSource(typeof(SuccessCirlceTestCaseSource), nameof(SuccessCirlceTestCaseSource.testCircles))]
        public void ValidCircles_Success(SquareTestCaseModel<Circle> caseModel)
        {
            //Arrange
            double expectedSquare = caseModel.ExpectedSquare;

            //Action
            double actualSquare = calculator.GetSquare(caseModel.Figure);

            //Assert
            Assert.AreEqual(expectedSquare, actualSquare);
        }
    }
}