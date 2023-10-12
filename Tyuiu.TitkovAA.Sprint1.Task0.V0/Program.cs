using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.TitkovAA.Sprint1.Task0.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*                                                                         *");
            Console.Title = "Спринт #1 | Выполнил: Титков А. А. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: решение задания                                                   *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* (48 / 12) - (48 / (6 / 4))                                              *");
            Console.WriteLine("***************************************************************************"); 
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService dt = new DataService();
            Console.WriteLine(dt.Calculate());
            Console.ReadKey();
        }
    }
}
