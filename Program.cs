/*create a simple project on .net using console of coffee shop simulatior: Ask the user to select coffee type( espresso, latte, 
    cappuccino)....Ask if they want extras( milk, sugar, whipped cream).....Calculate the total cost based on selections.*/

using games;

namespace coffeesimulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("select number: ");
            Console.WriteLine("1. CoffeeShopSimulator.");
            Console.WriteLine("2. NumberGuessingGame.");
            Console.WriteLine("3. Exit");
            Console.Write("\nEnter the number (1,2,3): ");

            string? number = Console.ReadLine();

            if(number == "1")
            {
                // if user choses 1, run coffee shop simulator
                CoffeeShopSimulator.Run();
            }
            else if(number == "2")
            {
                // if user choses 2,
                NumberGuessingGame.Run();
            }
            else
            {
                Console.WriteLine("Exit");
            }
            
            //first, give options to user
            // take user input


         

            // if user choses 3, then exit
        }
    }
}
