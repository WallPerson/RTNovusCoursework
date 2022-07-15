using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Area
{
    [TestFixture]
    internal class ShapeTest
    {
        [Test]
        public void CircleAreaTest()
        {
            double expectedValue = 78.54;
            Circle cir = new Circle();
            double rad = 5;
            double actualValue = Math.Round(cir.Area(rad),2);

            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]
        public void CirclePerimTest()
        {
            double expectedValue = 31.42;
            Circle cir = new Circle();
            double rad = 5;
            double actualValue = Math.Round(cir.Perimeter(rad),2);

            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]
        public void RecAreaTest()
        {
            double expectedValue = 125;
            Rectangle rec = new Rectangle();
            double height = 5;
            double width = 25;
            double actualValue = Math.Round(rec.Area(height,width), 2);

            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]
        public void RecPerimTest()
        {
            double expectedValue = 16;
            Rectangle rec = new Rectangle();
            double height = 5;
            double width = 3;
            double actualValue = Math.Round(rec.Perimeter(height,width), 2);

            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]
        public void TriAreaTest()
        {
            double expectedValue = 18;
            Triangle tri = new Triangle();
            double sideA = 5;
            double sideB = 3;
            double sideC = 10;
            double actualValue = Math.Round(tri.Area(sideA, sideB, sideC), 2);

            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]
        public void TriPerimTest()
        {
            double expectedValue = 18;
            Triangle tri = new Triangle();
            double sideA = 5;
            double sideB = 3;
            double sideC = 10;
            double actualValue = Math.Round(tri.Perimeter(sideA,sideB,sideC), 2);

            Assert.AreEqual(expectedValue, actualValue);

        }
    }
}
