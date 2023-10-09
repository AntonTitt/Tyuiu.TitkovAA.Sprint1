using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

using Tyuiu.TitkovAA.Sprint1.Task6.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {


            StringBuilder r = DataService.Func("abcd");
            string a, b = "bcda";
            a = Convert.ToString(r);

            Assert.AreEqual(a, b);



        }
    }
}
