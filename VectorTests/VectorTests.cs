using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1.Tests
{
    [TestClass()]
    public class VectorTests
    {
        [TestMethod()]
        public void VectorConstructorTest()
        {
            Point P1 = new Point(1, 2, 15);
            Point P2 = new Point(0, -3, 6);
            Point P3 = new Point(-1, 10, 9);
            Point P4 = new Point(8, -8, 19);
            string exp1 = "(-1; -5; -9)";
            string exp2 = "(9; -18; 10)";

            Vector act1 = new Vector(P1, P2);
            Vector act2 = new Vector(P3, P4);
            Assert.AreEqual(exp1, act1.ToString());
            Assert.AreEqual(exp2, act2.ToString());
        }
        [TestMethod()]
        public void VectorSumTest()
        {
            Vector vector1 = new Vector(-1, -5, -9);
            Vector vector2 = new Vector(9, -18, 10);
            string exp = "(8; -23; 1)";
            Vector act = vector1 + vector2;
            Assert.AreEqual(exp, act.ToString());
        }
        [TestMethod()]
        public void VectorSubTest()
        {
            Vector vector1 = new Vector(-1, -5, -9);
            Vector vector2 = new Vector(9, -18, 10);
            string exp = "(-10; 13; -19)";
            Vector act = vector1 - vector2;
            Assert.AreEqual(exp, act.ToString());
        }
        [TestMethod()]
        public void VectorScalMultiTest()
        {
            Vector vector1 = new Vector(-1, -5, -9);
            Vector vector2 = new Vector(9, -18, 10);
            string exp = "-9";
            double act = vector1 * vector2;
            Assert.AreEqual(exp, act.ToString());
        }
        [TestMethod()]
        public void VectorVectMultiTest()
        {
            Vector vector1 = new Vector(-1, -5, -9);
            Vector vector2 = new Vector(9, -18, 10);
            string exp = "(-212; -71; 63)";
            Vector act = vector1 | vector2;
            Assert.AreEqual(exp, act.ToString());
        }
        [TestMethod()]
        public void VectorGetLengthTest()
        {
            Vector vector1 = new Vector(-1, -5, -9);
            Vector vector2 = new Vector(9, -18, 10);
            string exp1 = "10,3440804327886";
            string exp2 = "22,4722050542442";
            double act1 = vector1.GetLength();
            double act2 = vector2.GetLength();
            Assert.AreEqual(exp1, act1.ToString());
            Assert.AreEqual(exp2, act2.ToString());
        }
    }
}