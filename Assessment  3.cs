using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment__3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"The maximum number is: {num1}");
            }
            else if (num2 > num1)
            {
                Console.WriteLine($"The maximum number is: {num2}");
            }
            else
            {
                Console.WriteLine("Both numbers are equal.");
            }

        }
    }
}
