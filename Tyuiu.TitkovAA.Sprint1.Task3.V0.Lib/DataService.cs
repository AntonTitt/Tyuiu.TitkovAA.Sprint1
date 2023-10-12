using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TitkovAA.Sprint1.Task3.V0.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public double NumberToMoney(double a)
        {
            int z, b;
            b = (int)a;
            z = (int)((a - b) * 100);

            //return $"{a} руб. -- это {b} руб. {z} коп.";
            return b + z;
        }
    }
}
