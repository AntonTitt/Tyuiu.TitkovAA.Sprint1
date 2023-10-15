using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TitkovAA.Sprint1.Task4.V0.Lib
{
    public class DataService:ISprint1Task4V10
    {
        public double Calculate(double a)
        {

            return (1 + Math.Cos(a)) / (Math.Sin(a) * Math.Sin(a));
        }
    }
}
