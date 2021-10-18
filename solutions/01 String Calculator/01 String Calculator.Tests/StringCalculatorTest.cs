using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_String_Calculator.Tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        private StringCalculator stringCalculator;

        [TestInitialize]
        public void SetUp()
        {
            stringCalculator = new StringCalculator();
        }

        [TestMethod]
        public void AnEmptyStringReturnsZero()
        {
            Assert.AreEqual(0, stringCalculator.Calculate(""));
        }

        [TestMethod]
        public void ASingleNumberReturnsTheValue()
        {
            Assert.AreEqual(2, stringCalculator.Calculate("2"));
        }

        [TestMethod]
        public void TwoNumbersCommaDelimitedReturnsTheSum()
        {
            Assert.AreEqual(5, stringCalculator.Calculate("2,3"));
        }

        [TestMethod]
        public void TwoNumbersNewLineDelimitedReturnsTheSum()
        {
            Assert.AreEqual(5, stringCalculator.Calculate("2\n3"));
        }

        [TestMethod]
        public void ThreeNumbersDelimitedEitherWayReturnsTheSum()
        {
            Assert.AreEqual(6, stringCalculator.Calculate("1,2\n3"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NegativeNumbersThrowAnException()
        {
            stringCalculator.Calculate("-1");
        }

        [TestMethod]
        public void NumbersGreaterThan1000AreIgnored()
        {
            Assert.AreEqual(1003, stringCalculator.Calculate("1000,1001,3"));
        }

        [TestMethod]
        public void ASingleCharDelimiterCanBeDefinedOnTheFirstLine()
        {
            Assert.AreEqual(5, stringCalculator.Calculate("//#2#3"));
        }

        [TestMethod]
        public void AMultiCharDelimiterCanBeDefinedOnTheFirstLine()
        {
            Assert.AreEqual(5, stringCalculator.Calculate("//[###]2###3"));
        }

        [TestMethod]


        public void ManySingleOrMultiCharDelimitersCanBeDefined()
        {
            Assert.AreEqual(6, stringCalculator.Calculate("//[###][$$]2###3$$1"));
        }
    }

}
