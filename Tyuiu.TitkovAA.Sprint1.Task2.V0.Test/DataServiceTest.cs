using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint1.Task2.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            double re = dt.ConvertKmToM(45);

            Assert.AreEqual(re, 72.405);
        }
    }
}
