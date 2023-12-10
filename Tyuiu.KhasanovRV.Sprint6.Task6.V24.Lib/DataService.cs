using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhasanovRV.Sprint6.Task6.V24.Lib
{
    public class DataService : ISprint6Task6V24
    {
            public string CollectTextFromFile(string path)
            {
                string str = " ";
                string resStr = "";
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(str))
                        {
                            resStr = resStr + line.Split()[0] + " ";
                        }
                    }
                }

                return resStr;
            }
    }
}
