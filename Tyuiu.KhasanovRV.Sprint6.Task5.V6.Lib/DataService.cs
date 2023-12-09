﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhasanovRV.Sprint6.Task5.V6.Lib
{
    public class DataService : ISprint6Task5V6
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 3 == 0)
                    {
                        len++;
                    }

                }
            }

            double[] array = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line)  % 3 == 0)
                    {
                        array[index] = Convert.ToDouble(line);
                        index++;
                    }

                }

            }
            return array;
        }
    }
}
