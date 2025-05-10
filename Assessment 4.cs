using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a number between 1 and 10: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

        }
    }
}
