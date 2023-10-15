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

            DataService dt = new DataService();
            string res = dt.MoveLetterToEnd("abcd");

            Assert.AreEqual(res, "bcda");



        }
    }
}
