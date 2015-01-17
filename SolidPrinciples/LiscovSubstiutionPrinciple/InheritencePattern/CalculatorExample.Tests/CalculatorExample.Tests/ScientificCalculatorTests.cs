using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorExample.Domain;

namespace CalculatorExample.Tests
{
    [TestClass]
    public class ScientificCalculatorTests
    {
        [TestMethod]
        public void WhenAddingTwoNumbers_ItShouldProvideTheCorrectResult()
        {
            var scientificCalculator = new ScientificCalculator();
            var result  = scientificCalculator.Add(2, 2);
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void WhenFindingTheSquareRoot_ItShouldProvideTheCorrectResult()
        {
            var scientificCalculator = new ScientificCalculator();
            var result = scientificCalculator.SquareRoot(4);
            Assert.AreEqual(result, 2);
        }
    }
}
