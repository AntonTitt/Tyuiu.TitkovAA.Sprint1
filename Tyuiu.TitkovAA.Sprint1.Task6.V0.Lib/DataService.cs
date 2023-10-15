using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TitkovAA.Sprint1.Task6.V0.Lib
{
    public class DataService:ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            StringBuilder c = new StringBuilder();
            StringBuilder b = new StringBuilder();

            b.Append(value);


            for (int i = 0; i < b.Length - 1; i++)
            {
                c.Append(b[i + 1]);
            }
            c.Append(b[0]);

            return Convert.ToString(c);
        }
    }
}
