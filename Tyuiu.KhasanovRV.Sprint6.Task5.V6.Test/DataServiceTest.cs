using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint6.Task5.V6.Lib;

namespace Tyuiu.KhasanovRV.Sprint6.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = $@"C:\Users\Renat\source\repos\Tyuiu.KhasanovRV.Sprint6\Tyuiu.KhasanovRV.Sprint6.Task5.V6\bin\Debug\InPutFileTask5V6.txt";


            double[] resArr;
            resArr = ds.LoadFromDataFile(path);
            double[] wait = new double[ds.len];
            wait[0] = -12;

            CollectionAssert.AreEqual(wait, resArr);
        }
    }
}
