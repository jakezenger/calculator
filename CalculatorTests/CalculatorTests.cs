using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void DivideTest()
        {
            float num1 = 2.6f, num2 = 3.5f;

            float expected = num1 / num2;
            float actual = Calculator.Divide(num1, num2);

            Assert.AreEqual(expected, actual);
        }
    }
}