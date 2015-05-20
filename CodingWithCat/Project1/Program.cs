using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        /*
         *  input two numbers, separated by one space, and output the sum of the two numbers
         *  Quit when given 0 for both numbers
         */
        static void Main(string[] args)
        {
            while (true)
            {
                var line = Console.ReadLine();
                var inputs = line.Split(' ');
                var num1 = int.Parse(inputs[0]);
                var num2 = int.Parse(inputs[1]);

                if (num1 == 0 && num2 == 0)
                {
                    break;
                }

                Console.WriteLine(num1 + num2);
            }
        }
    }
}
