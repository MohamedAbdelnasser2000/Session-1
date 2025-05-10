using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            string operation;
            
            Console.Write("Enter the first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter an operation (+, -, *, /): ");
            operation = Console.ReadLine();
           
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
           
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
           
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
           
                case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    
                    break;
           
                default:
                    Console.WriteLine("Invalid operation! Please use +, -, * or /.");
                    break;
            }
           
        }
    }
}
