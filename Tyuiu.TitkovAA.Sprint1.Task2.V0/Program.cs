using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.TitkovAA.Sprint1.Task2.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            double km;

            Console.WriteLine("Введите расстояние (км): ");
            km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DataService.Func(km));


        }
    }
}
