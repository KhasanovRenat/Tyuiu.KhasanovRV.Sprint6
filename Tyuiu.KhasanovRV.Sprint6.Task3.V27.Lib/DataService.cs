using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhasanovRV.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            int[] list = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                list[i] = matrix[i,3];
            }
            Array.Sort(list);
            for (int i = 0;i < rows; i++)
            {
                matrix[i, 3] = list[i];
            }
            return matrix;
        }
    }
}
