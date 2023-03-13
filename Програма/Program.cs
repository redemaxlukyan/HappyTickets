using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Програма
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            int sum = 0;
            for (int number = 000001; number <= 999999; number++)
            {
                int number1 = number % 1000000 / 100000;
                int number2 = number % 100000 / 10000;
                int number3 = number % 10000 / 1000;
                int number4 = number % 1000 / 100;
                int number5 = number % 100 / 10;
                int number6 = number % 10;

                if ((number1 + number2 + number3) == (number4 + number5 + number6))
                {
                    sum++;
                }
            }

            Console.WriteLine(sum);

            Console.ReadKey();

        }
    }
}
