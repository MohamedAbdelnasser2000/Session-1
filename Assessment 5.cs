using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int targetNumber = random.Next(1, 101); 
            int maxAttempts = 5;
            int guess;

            Console.WriteLine(" Welcome !");
            Console.WriteLine("I have chosen a number between 1 and 100.");
            Console.WriteLine($"You have {maxAttempts} attempts to guess it.\n");

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write($"Attempt {attempt}/{maxAttempts} - Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());


                if (guess == targetNumber)
                {
                    Console.WriteLine(" You guessed the correct number!");
                    break;
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine(" Too high! Try again.\n");
                }
      

                if (attempt == maxAttempts)
                {
                    Console.WriteLine($" Game over! The correct number was: {targetNumber}");
                }
            }

            Console.WriteLine("\nThanks for playing!");
        }
    }
}
