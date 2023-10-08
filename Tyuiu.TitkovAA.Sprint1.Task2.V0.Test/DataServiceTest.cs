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
            double re = DataService.Func(45);
            Assert.AreEqual(re, 72.405);
        }
    }
}
