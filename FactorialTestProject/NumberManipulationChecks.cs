using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactorialTrailingZeros;

namespace FactorialTestProject
{
    [TestClass]
    public class NumberManipulationChecks
    {
        [TestMethod]
        public void Testing_No_To_Base_Conversion()
        {
            int num = TrailZerosFact.ConvertFromBase10(5, 2);
            Assert.AreEqual(101,num);
        }

        //[TestMethod]
        //public void Getting_Prime_Nos_Till_Number_Test()
        //{
        //    int[] res = { 10,101};
        //    int[] primes = TrailZerosFact.GetAllPrimeNosTill(13, 7);
        //    Assert.AreEqual(res,primes);
        //}
    }
}
