//Build a Number Guessing Game (1-1000).
using System;
namespace games
{
    class NumberGuessingGame
    {
        public static void Run()
        {
            Random random = new Random();
            int secretnumber = random.Next(1, 1001);

            int guess = 10;
            Console.WriteLine("Number guessing game");
            Console.WriteLine("Guess a number between 1 to 1000");

            while (guess != secretnumber)
            {
                Console.Write("\nEnter your guess number: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < secretnumber)
                {
                    Console.WriteLine("Too low .");
                }
                else if (guess > secretnumber)
                {
                    Console.WriteLine("Too high .");
                }
                else
                {
                    Console.WriteLine("Congratulations you guessed the correct number.");
                }
            }
        }
    }
}
