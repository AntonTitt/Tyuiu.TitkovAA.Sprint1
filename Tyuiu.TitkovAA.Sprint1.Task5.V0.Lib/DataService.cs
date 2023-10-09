using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.TitkovAA.Sprint1.Task5.V0.Lib
{
    public class DataService
    {
        public static StringBuilder Func(string a)
        {
            StringBuilder c = new StringBuilder();
            StringBuilder b = new StringBuilder();

            b.Append(a);


            for (int i = 0; i < b.Length - 1; i++)
            {
                c.Append(b[i + 1]);
            }
            c.Append(b[0]);

            return c;
        }
    }
}
