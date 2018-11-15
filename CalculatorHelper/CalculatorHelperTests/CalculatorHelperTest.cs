using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorHelper;

namespace CalculatorHelperTests
{
    [TestClass]
    public class CalculatorHelperTest
    {
        [TestMethod]
        public void Add_HappyPath()
        {
            Assert.AreEqual(20, CalculatorLib.Sum(15, 5));
        }

        [TestMethod]
        public void Sum_HappyPath()
        {
            Assert.AreEqual(10, CalculatorLib.Substract(15, 5));
        }

        [TestMethod]
        public void Multiplication_HappyPath()
        {
            Assert.AreEqual(75, CalculatorLib.Multiplication(15, 5));
            Assert.AreEqual(45, CalculatorLib.Multiplication(15, 3));
            Assert.AreEqual(60, CalculatorLib.Multiplication(15, 4));
        }

        [TestMethod]
        public void Substract_HappyPath()
        {
            Assert.AreEqual(3, CalculatorLib.Substract(15, 10));
            Assert.AreEqual(3, CalculatorLib.Substract(15, 10));
        }

        [TestMethod]
        public void Substract_DivideZero()
        {
            Assert.AreEqual(0, CalculatorLib.Division(15, 0));
        }
    }
}
