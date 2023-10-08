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
            double r = DataService.Func(55, 343);
            Assert.AreEqual(r, 336);
        }
    }
}
