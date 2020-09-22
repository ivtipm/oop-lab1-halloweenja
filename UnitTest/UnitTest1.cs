using System;
using ClassLibraryCN;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    { 
        ClassCN testClass = new ClassCN();
        [TestMethod]
        public void Test_sum()
        {
            ClassCN temp = new ClassCN(1, 1);
            testClass = testClass + temp;
            Assert.AreEqual(testClass.ToString(), temp.ToString(), "Ошибка в сложении комплексного чила с комплексным числом");
        }
        [TestMethod]
        public void Test_sum_numb()
        {
            int a = 1;
            testClass = testClass + a;
            Assert.AreEqual(testClass.Re, 1, "Ошибка в сложении комплексного чила с реальным числом");
        }   
        [TestMethod]
        public void Test_subtract_numb()
        {
            int a = 1;
            testClass = testClass - a;
            Assert.AreEqual(testClass.Re, -1, "Ошибка в вычитании реального чила из комплексным числом");
        }
        [TestMethod]
        public void Test_subtract()
        {
            ClassCN temp = new ClassCN(1, 1);
            String answer = "-1 + i-1";
            testClass = testClass - temp;
            Assert.AreEqual(testClass.ToString(), answer, "Ошибка в вычитании комплексного чила из комплексным числом");
        }
        [TestMethod]
        public void Test_multiplication()
        {
            ClassCN temp = new ClassCN(2, 2);
            testClass = new ClassCN(2, 2);
            String answer = "0 + i8";
            testClass = testClass * temp;
            Assert.AreEqual(testClass.ToString(), answer, "Ошибка в произведении комплексного числа на комплексное число");
        }
        [TestMethod]
        public void Test_multiplication_numb()
        {
            testClass = testClass * 5;
            Assert.AreEqual(testClass.ToString(), testClass.ToString(), "Ошибка в произведении комплексного числа на реально число");
        }
        [TestMethod]
        public void Test_argument()
        {
            testClass = new ClassCN(1, 1);
            Assert.AreEqual(testClass.argument(), 45.0, "Ошибка в нахождениии аргумента");
        }
}
}
