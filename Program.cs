using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, reverse = 0, copy;
            Console.Write("Enter first number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            copy = number1;
            while (number1 > 0)
            {
                reverse = reverse * 10;
                reverse = reverse + (number1 % 10);
                number1 = number1 / 10;
            }

            Console.WriteLine("Reverse of " + copy + " is " + reverse);
            Console.ReadLine();
        }
    }
}
