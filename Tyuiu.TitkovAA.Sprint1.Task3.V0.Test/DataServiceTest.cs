using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint1.Task3.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(DataService.Func(6345.2314), "6345,2314 руб. -- это 6345 руб. 23 коп.");
        }
    }
}
