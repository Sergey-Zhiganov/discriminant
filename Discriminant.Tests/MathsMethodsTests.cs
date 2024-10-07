using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Discriminant.Tests
{
    [TestClass]
    public class MathsMethodsTests
    {
        double delta = 0.001;
        static List<double[]> discriminantData;
        static List<double[]> percentData;
        MathsMethods Methods = new MathsMethods();
        double? x1, x2;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            discriminantData = new List<double[]>
            {
                new double[] { 1, 2 ,5 },
                new double[] { 1, 2 ,1 },
                new double[] { 1, -3, 2}
            };

            percentData = new List<double[]>
            {
                new double[] { 249.56, 25.7, 64.137 }
            };
        }

        [TestMethod]
        public void Discriminant_FindDiscriminant_returnNullNull()
        {
            double a = discriminantData[1][0];
            double b = discriminantData[1][1];
            double c = discriminantData[1][2];

            (x1, x2) = Methods.Discriminant(a, b, c);

            Assert.IsTrue(x1 < 0);
            Assert.IsTrue(x2 < 0);
        }

        [TestMethod]
        public void Discriminant_FindDiscriminant_returnOneRoot()
        {
            double a = discriminantData[1][0];
            double b = discriminantData[1][1];
            double c = discriminantData[1][2];

            (x1, x2) = Methods.Discriminant(a, b, c);

            Assert.AreEqual(x1, x2);
            Assert.IsNotNull(x1);
        }

        [TestMethod]
        public void Discriminant_FindDiscriminant_returnTwoRoots()
        {
            double a = discriminantData[2][0];
            double b = discriminantData[2][1];
            double c = discriminantData[2][2];

            (x1, x2) = Methods.Discriminant(a, b, c);

            Assert.AreNotEqual(x1, x2);
            Assert.IsNotNull(x1);
            Assert.IsNotNull(x2);
        }

        [TestMethod]
        public void PercentOfNumber_FindPercentOfNumber_Return50()
        {
            double number = percentData[0][0];
            double percent = percentData[0][1];
            double expected = percentData[0][2];

            double actual = Methods.PercentOfNumber(number, percent);

            Assert.AreEqual(expected, actual, delta);
        }
    }
}
