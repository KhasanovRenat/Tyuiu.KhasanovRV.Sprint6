using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhasanovRV.Sprint6.Task2.V23.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int s = -1;
            int e = 1;
            double[] arr = new double[3];
            arr[0] = 5.36;
            arr[1] = 2.5;
            arr[2] = 0;
            double[] wait = ds.GetMassFunction(s, e);
            CollectionAssert.AreEqual(wait, arr);
        }

    }
}
