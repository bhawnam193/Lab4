using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleClass;

namespace NUnitDemonstration.Tests
{

    //Bhawna Bhawna - 8844876

    public class TestTriangle
    {

        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            string expected = "The triangle is NOT valid.";
            var triangle = new Triangle();
            string actual = triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual(expected, actual);

        }


        [Test]
        public void InvalidTriangle()
        {
            int firstAngle = 80;
            int secondAngle = 60;
            int thirdAngle = 60;
            string expected = "The triangle is valid.";
            var triangle = new Triangle();
            string actual = triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual(expected, actual);

        }


    }
}
