using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhasanovRV.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] arr = new double[len];
            double y;
            int cnt = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != 1)
                {
                    y = Math.Round(4 - 2 * x + (2 + Math.Cos(x)) / (2 * x - 2), 2);
                }
                else
                {
                    y = 0;
                }
                arr[cnt] = y;
                cnt++;
            }
            return arr;
        }
    }
}
