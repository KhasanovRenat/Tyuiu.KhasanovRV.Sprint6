using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhasanovRV.Sprint6.Task4.V10.Lib
{
    public class DataService : ISprint6Task4V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] resArr;
            int len = (stopValue - startValue) + 1;
            resArr = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 3 == 0)
                {
                    resArr[count] = 0;
                    count++;
                    continue;
                }
                else
                {
                    y = Math.Round((5 * x + 2.5) / (Math.Sin(x) + 3) + 2 * x + Math.Cos(x), 2);
                    resArr[count] = y;
                    count++;
                }

            }
            return resArr;
        }
    }
}
