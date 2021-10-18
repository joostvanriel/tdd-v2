using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Writing_a_first_unit_test.Tests
{
    [TestClass]
    public class StrangeNumberTest
    {
        private StrangeNumber strangeNumber;

        [TestInitialize]
        public void SetUp()
        {
            strangeNumber = new StrangeNumber();
        }

        [TestMethod]
        public void GetDouble_AfterCreation_ReturnsZero()
        {
            // assert
            Assert.AreEqual(0.0, strangeNumber.GetDouble());
        }

        [TestMethod]
        public void Add_PositiveNumbers_GetDoubleReturnsPositive()
        {
            // act
            strangeNumber.Add(0.00001);

            // assert
            Assert.AreEqual(0.00001, strangeNumber.GetDouble());
        }

        [TestMethod]
        public void Add_NegativeNumbers_GetDoubleReturnsNegative()
        {
            // act
            strangeNumber.Add(-0.00001);

            // assert
            Assert.AreEqual(-0.00001, strangeNumber.GetDouble());
        }

        [TestMethod]
        public void Substract_PositiveNumbers_GetDoubleReturnsNegative()
        {
            // act
            strangeNumber.Subtract(0.00001);

            // assert
            Assert.AreEqual(-0.00001, strangeNumber.GetDouble());
        }

        [TestMethod]
        public void Substract_NegativeNumbers_GetDoubleReturnsPositive()
        {
            // act
            strangeNumber.Subtract(0.00001);

            // assert
            Assert.AreEqual(-0.00001, strangeNumber.GetDouble());
        }

        [TestMethod]
        public void Divide_ByNonZero_GetDoubleReturnsDivision()
        {
            // arrange
            strangeNumber.Add(12.0);

            // act
            strangeNumber.Divide(4.0);

            // assert
            Assert.AreEqual(3.0, strangeNumber.GetDouble());
        }

        [TestMethod]
        public void Divide_PositiveNumberByZero_GetDoubleReturnsPositiveInfinity()
        {
            // arrange
            strangeNumber.Add(3.0);

            // act
            strangeNumber.Divide(0.0);

            // assert
            Assert.AreEqual(double.PositiveInfinity, strangeNumber.GetDouble());
        }

        [TestMethod]
        public void Divide_NegativeNumberByZero_GetDoubleReturnsNegativeInfinity()
        {
            // arrange
            strangeNumber.Add(-3.0);

            // act
            strangeNumber.Divide(0.0);

            // assert
            Assert.AreEqual(double.NegativeInfinity, strangeNumber.GetDouble());
        }

        [TestMethod]
        public void Multiply_GetDoubleReturnsMultiplication()
        {
            // arrange
            strangeNumber.Add(9.0);

            // act
            strangeNumber.Multiply(3.0);

            // assert
            Assert.AreEqual(27.0, strangeNumber.GetDouble());
        }
    }
}
