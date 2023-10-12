using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint1.Task1.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            double r = dt.Calculate(55, 343);
            Assert.AreEqual(r, 336.875);
        }
    }
}
