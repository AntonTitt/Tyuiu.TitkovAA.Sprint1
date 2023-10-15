using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TitkovAA.Sprint1.Task5.V0.Lib
{
    public class DataService:ISprint1Task1V13
    {
        public double Calculate(double x)
        {
            double d;
            d = (int)((x - (int)x) * 10);
            return d;
        }
    }
}
