using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingMockClasses;
using Moq;

namespace NumberManipulationTesting
{
    [TestClass]
    public class NumberTests
    {
        NumberManipulation nm = new NumberManipulation();
        [TestMethod]
        public void Factorial_Testing_With_1()
        {
            Assert.AreEqual(1, nm.Factorial(1));
        }
        [TestMethod]
        public void Factorial_Testing_With_0()
        {
            Assert.AreEqual(1, nm.Factorial(0));
        }
        [TestMethod]
        public void Reverse_Testing_Normal_Number()
        {
            Assert.AreEqual(123, nm.Reverse(321));
        }
        [TestMethod]
        public void Reverse_Testing_With_0()
        {
            Assert.AreEqual(0, nm.Reverse(0));
        }
        [TestMethod]
        public void Test_No_Of_Digits_Normal()
        {
            Assert.AreEqual(3, nm.NoOfDigits(999));
        }
        [TestMethod]
        public void Test_No_Of_Digits_With_0()
        {
            Assert.AreEqual(1, nm.NoOfDigits(0));
        }
        [TestMethod]
        public void Mock_Test_No_Of_Digits_With_0()
        {
            Mock<NumberManipulation> nmMock = new Mock<NumberManipulation>();
            nmMock.Setup(x => x.NoOfDigits(0)).Returns(1);
            Assert.AreEqual(1, nmMock.Object.NoOfDigits(0));
        }
        [TestMethod]
        public void Test_Magic_no()
        {
            Assert.IsTrue(nm.IsMagicNo(100));
        }
    }
}
