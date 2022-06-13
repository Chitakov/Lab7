using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2.Tests
{
    [TestClass()]
    public class PolynomialTests
    {
        [TestMethod()]
        public void PolynomialSumTest()
        {
            Polynomial p1 = new Polynomial(1, 2, 3);
            Polynomial p2 = new Polynomial(10, 20, 0, 40);
            string exp = "11+22*x^1+3*x^2+40*x^3";
            Polynomial actual = new Polynomial();
            actual = p1 + p2;
            string act = "";
            int temp = actual.Order;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < temp; i++)
            {
                if (actual[i] != 0)
                {
                    if (i == 0)
                    {
                        sb.Append(actual[i]);
                    }
                    else
                    {
                        if (actual[i] > 0)
                        {
                            sb.Append("+" + actual[i] + "*x^" + i);
                        }
                        else
                        {
                            sb.Append(actual[i] + "*x^" + i);
                        }
                    }
                }
            }
            act += sb;
            Assert.AreEqual(exp, act);
        }
        [TestMethod()]
        public void PolynomialSubTest()
        {
            Polynomial p1 = new Polynomial(1, 2, 3);
            Polynomial p2 = new Polynomial(10, 20, 0, 40);
            string exp = "-9-18*x^1+3*x^2-40*x^3";
            Polynomial actual = new Polynomial();
            actual = p1 - p2;
            string act = "";
            int temp = actual.Order;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < temp; i++)
            {
                if (actual[i] != 0)
                {
                    if (i == 0)
                    {
                        sb.Append(actual[i]);
                    }
                    else
                    {
                        if (actual[i] > 0)
                        {
                            sb.Append("+" + actual[i] + "*x^" + i);
                        }
                        else
                        {
                            sb.Append(actual[i] + "*x^" + i);
                        }
                    }
                }
            }
            act += sb;
            Assert.AreEqual(exp, act);
        }
        [TestMethod()]
        public void PolynomialMultiTest()
        {
            Polynomial p1 = new Polynomial(1, 2, 3);
            Polynomial p2 = new Polynomial(10, 20, 0, 40);
            string exp = "10+40*x^1+70*x^2+100*x^3+80*x^4+120*x^5";
            Polynomial actual = new Polynomial();
            actual = p1 * p2;
            string act = "";
            int temp = actual.Order;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < temp; i++)
            {
                if (actual[i] != 0)
                {
                    if (i == 0)
                    {
                        sb.Append(actual[i]);
                    }
                    else
                    {
                        if (actual[i] > 0)
                        {
                            sb.Append("+" + actual[i] + "*x^" + i);
                        }
                        else
                        {
                            sb.Append(actual[i] + "*x^" + i);
                        }
                    }
                }
            }
            act += sb;
            Assert.AreEqual(exp, act);
        }
        [TestMethod()]
        public void PolynomialCalculateTest()
        {
            Polynomial p1 = new Polynomial(1, 2, 3);
            Polynomial p2 = new Polynomial(10, 20, 0, 40);
            double x = 1;
            double actp1, actp2;
            double expp1 = 6;
            double expp2 = 70;
            actp1 = p1.Calculate(x);
            actp2 = p2.Calculate(x);
            Assert.AreEqual(expp1, actp1);
            Assert.AreEqual(expp2, actp2);
        }
    }
}