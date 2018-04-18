using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HiNLowWhiteBoxTest1;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnSumOf1plus2()
        {
            int result;
            result = HighAndLow.Instance.GetSum(HighAndLow.Instance.RollDice(new int[] { 1, 2 }));

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestIfDiceIsHigherThan6()
        {
            HighAndLow.Instance.GetSum(HighAndLow.Instance.RollDice(new int[] { 7, 7 }));

        }
    }
}
