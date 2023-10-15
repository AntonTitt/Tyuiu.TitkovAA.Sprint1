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
            DataService dt = new DataService();
            double c = 6345.2314;
            double a = dt.NumberToMoney(6345.2314);
            
            int z, b;
            b = (int)a;
            z = (int)((a - b) * 100);
            
            string res = Convert.ToString(c) + " руб. -- это " + Convert.ToString(b) + " руб. " + Convert.ToString(z) + " коп.";

            Assert.AreEqual(res, "6345,2314 руб. -- это 6345 руб. 23 коп.");
        }
    }
}
