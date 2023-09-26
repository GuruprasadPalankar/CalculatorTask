using System;
using NUnit.Framework;
using CalculatorLogic;
using CalculatorTask;
using Moq;

namespace CalculatorLogicTest
{
    [TestFixture]
    public class OperationTest
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(1045, 344.5, 1389.5)]
        [TestCase(-23.33, -465.7643, -489.0943)]
        [TestCase(5.4, 2.0, 7.4)]
        public void AdditionTask(double num1, double num2, double expected)
        {
            var mock = new Mock<Addition>();
            var addobj = mock.Object;
            Assert.AreEqual(expected, addobj.Operation(num1, num2));
        }


        [TestCase(1045, 344.5, 700.5)]
        [TestCase(-23.33, -465.7643, 442.4343)]
        [TestCase(5.7, 2, 3.7)]
        public void SubtractionTask(double num1, double num2, double expected)
        {
            var mock = new Mock<Subtraction>();
            var subobj = mock.Object;
            Assert.AreEqual(expected, subobj.Operation(num1, num2));
        }


        [TestCase(1045, 344.5, 360002.5)]
        [TestCase(-23.33, -465.7643, (-23.33 * -465.7643))]
        [TestCase(5.4, 2.0, 10.8)]
        public void MultiplicationTask(double num1, double num2, double expected)
        {
            var mock = new Mock<Multiplication>();
            var mulobj = mock.Object;
            Assert.AreEqual(expected, mulobj.Operation(num1, num2));
        }


        [TestCase(1045, 344.5, (1045 / 344.5))]
        [TestCase(-23.33, -465.7643, (-23.33 / -465.7643))]
        [TestCase(5.4, 2.0, 2.7)]
        public void DivisionTask(double num1, double num2, double expected)
        {
            var mock = new Mock<Division>();
            var divobj = mock.Object;
            Assert.AreEqual(expected, divobj.Operation(num1, num2));
        }

        [TestCase(2.5, 2, 6.25)]
        [TestCase(2.25, 2, 5.0625)]
        [TestCase(2, 3, 8)]
        public void PowerTask(double num1, double num2, double expected)
        {
            var mock = new Mock<Power>();
            var powobj = mock.Object;
            Assert.AreEqual(expected, powobj.Operation(num1, num2));
        }
    }
}