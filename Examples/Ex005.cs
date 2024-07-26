using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadBook.CsharpBasic.Chapter05.Examples
{
    internal class Ex005
    {
        public void Run()
        {
            Sum(1, 1);
            Sum(2, 2);
            Sum(3, 3);
        }

        private void Sum(int number01, int number02)
        {

            Console.WriteLine("{0} + {1} = {2}", number01, number02, number01 + number02);
        }
    }
}
