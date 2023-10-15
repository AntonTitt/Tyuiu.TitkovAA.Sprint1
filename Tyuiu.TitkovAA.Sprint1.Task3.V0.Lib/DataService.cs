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
            int b;
            double c;
            b = (int)a;
            c = a - b;
            //return $"{a} руб. -- это {b} руб. {z} коп.";
            return b + c;//x,xx
        }
    }
}
