using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint6.Task0.V6.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int x = 3;
            var y = ds.Calculate(x);

            double wait = 0.866;

            Assert.AreEqual(wait, y);
        }
    }
}
