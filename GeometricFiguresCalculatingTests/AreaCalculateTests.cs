using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricFiguresCalculating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresCalculating.Tests
{
    [TestClass()]
    public class AreaCalculateTests
    {
        [TestMethod()]
        public void CircleAreaTest_Redius10_62dot8returned()
        {
            double radius = 10;

            double expected = radius * 2 * Math.PI;

            AreaCalculate circleTest = new AreaCalculate();

            double actual = circleTest.CircleArea(radius);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TriangleAreaTest_sides_a10b20c25_94dot992returned()
        {
            double sideA = 10;
            double sideB = 20;
            double sideC = 25;

            double semiPerimeter = (sideA + sideB + sideC) / 2;

            double p = semiPerimeter;

            double expected = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            AreaCalculate triangleTest = new AreaCalculate();

            double actual = triangleTest.TriangleArea(sideA, sideB, sideC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsTriangleRectangularTest_sides_a3b4c5_trueReturned()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            bool expected = true;

            AreaCalculate triangleTest = new AreaCalculate();

            bool actual = triangleTest.IsTriangleRectangular(sideA, sideB, sideC);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RectangleAreaTest()
        {
            double sideA = 10;
            double sideB = 20;

            double expected = sideA * sideB;

            AreaCalculate rectangleTest = new AreaCalculate();

            double actual = rectangleTest.RectangleArea(sideA, sideB);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IrregularQuadrilateralAreaTest()
        {
            double sideA = 4;
            double sideB = 5;
            double sideC = 7;
            double sideD = 9;

            double perimeter = sideA + sideB + sideC + sideD;
            double p = perimeter / 2;

            double expected = Math.Sqrt((p - sideA) * (p - sideB) * (p - sideC) * (p - sideD));

            AreaCalculate quadrilateralTest = new AreaCalculate();

            double actual = quadrilateralTest.IrregularQuadrilateralArea(sideA, sideB, sideC, sideD);

            Assert.AreEqual(expected, actual);
        }
    }
}