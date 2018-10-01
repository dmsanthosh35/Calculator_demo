using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using Sum;

namespace Test_Sum
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int num1 = 10;
            int num2 = 20;
            int expected = 30;

            //Act
            int actual = Sum.Class1.sum(num1, num2);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
