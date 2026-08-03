//Build a Number Guessing Game (1-1000).
using System;
namespace games
{
    class CoffeeShopSimulator
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to the Coffee Shop");

            Console.WriteLine("Please select a coffee type:");
            Console.WriteLine("1. Espresso (800)");
            Console.WriteLine("2. Latte (1100)");
            Console.WriteLine("3. Cappucino (1500)");
            Console.Write("\nEnter the number of your choice:");

            string? coffeeChoice = Console.ReadLine();
            int totalCost = 0;

            if (coffeeChoice == "1")
            {
                totalCost = 800;
                Console.WriteLine("You selected Espresso.");
            }
            else if (coffeeChoice == "2")
            {
                totalCost = 1100;
                Console.WriteLine("You selected Latte.");
            }
            else if (coffeeChoice == "3")
            {
                totalCost = 1500;
                Console.WriteLine("You selected Cappucino.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.Write("\nDo you want milk? (yes/no): ");
            String? milkChoice = Console.ReadLine();
            if (milkChoice == "yes")
            {
                totalCost = totalCost + 200;
            }


            Console.Write("\nDo you want sugar? (yes/no): ");
            String? sugarChoice = Console.ReadLine();
            if (sugarChoice == "yes")
            {
                totalCost = totalCost + 100;
            }

            Console.Write("\nDo you want whipped cream? (yes/no): ");
            String? whippedcreamChoice = Console.ReadLine();
            if (whippedcreamChoice == "yes")
            {
                totalCost = totalCost + 300;
            }

            Console.WriteLine("\n.............");
            Console.WriteLine("Total Cost : " + totalCost);
            Console.WriteLine("Thank you for your order!");

        }
    }
}
