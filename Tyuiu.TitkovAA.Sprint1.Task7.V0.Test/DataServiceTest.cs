using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint1.Task7.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            double res = dt.Calculate(4, 5);
            Assert.AreEqual(res, 2, 1819393074694);
        }
    }
}
