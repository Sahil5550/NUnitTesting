using NUnit.Framework;
using NUnitDemonstration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class Class1
    {
        public void TriangleWithoutMutant_Input60and60and70_OutputTriangle()
        {
            int firstAngle = 60;
            int secondAngle = 50;
            int thirdAngle = 60;

            string expected = "The triangle is valid.";
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual(expected, actual);
        }
    }
}

