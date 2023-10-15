using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.TitkovAA.Sprint1.Task4.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dt = new DataService();
            double res = dt.Calculate(4);

            Assert.AreEqual(res, 0.604725218531519);


        }
    }
}
