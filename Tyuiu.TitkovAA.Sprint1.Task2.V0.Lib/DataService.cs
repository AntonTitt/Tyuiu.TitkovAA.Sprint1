using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TitkovAA.Sprint1.Task2.V0.Lib
{
    public class DataService : ISprint1Task2V1
    {


        public double ConvertKmToM(int a)
        {

            return Math.Round(a * 1.609, 3);
        }

        
    }
}
