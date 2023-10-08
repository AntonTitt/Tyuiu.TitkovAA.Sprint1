using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.TitkovAA.Sprint1.Task3.V0.Lib
{
    public class DataService
    {
        public static string Func(double a)
        {
            int z, b;
            b = (int)a;
            z = (int)((a - b) * 100);

            return $"{a} руб. -- это {b} руб. {z} коп.";
        }
    }
}
