using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint6.Task1.V2.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int s = -1;
            int e = 1;
            double[] arr = new double[3];
            arr[0] = -2.16;
            arr[1] = 3.25;
            arr[2] = 6.64;
            double[] wait = ds.GetMassFunction(s, e);
            CollectionAssert.AreEqual(wait, arr);
        }
    }
}
