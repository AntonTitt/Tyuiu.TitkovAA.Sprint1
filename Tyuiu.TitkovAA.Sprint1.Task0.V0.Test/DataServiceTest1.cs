using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint1.Task0.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.Task0.V0.Test
{
    [TestClass]
    public class DataServiceTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res=DataService.Func();
            Assert.AreEqual(res, -44);
        }
    }
}
