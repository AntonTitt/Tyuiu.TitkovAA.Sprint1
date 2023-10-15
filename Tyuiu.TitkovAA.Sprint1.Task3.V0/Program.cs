using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Tyuiu.TitkovAA.Sprint1.Task3.V0.Lib;

namespace Tyuiu.TitkovAA.Sprint1.Task3.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("*                                                                         *");
            //Console.WriteLine("***************************************************************************");
            //75симв->

            Console.Title = "Спринт #1 | Выполнил: Титков А. А. | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: решение задания                                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Титков А. А. | РПСб-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая преобразует введенное с клавиатуры дробное  *");
            Console.WriteLine("* число в денежный формат.                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите число: ");
            double a,c;
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            DataService dt = new DataService();
            c = dt.NumberToMoney(6345.2314);

            int z, b;
            b = (int)a;
            z = (int)((a - b) * 100);

            string res = Convert.ToString(c) + " руб. -- это " + Convert.ToString(b) + " руб. " + Convert.ToString(z) + " коп.";

            Console.WriteLine(res);


        }
    }
}
