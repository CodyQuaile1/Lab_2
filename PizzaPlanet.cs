using System;

namespace Labs2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPies = 0;
            int amountOfToppings = 0;
            double driversTip = 0;
            double orderCost = 0;
            double DRIVERS_WAGE = 5.27;
            int COST_OF_PIE = 10;
            double COST_OF_TOPPING = 0.25;          // declare variables
            
            
            
            Console.WriteLine("How many pizzas?");
            numberOfPies = int.Parse(Console.ReadLine()); 

            Console.WriteLine("How many toppings?");
            amountOfToppings = int.Parse(Console.ReadLine());

            Console.WriteLine("How much would you like to tip the driver");
            driversTip = int.Parse(Console.ReadLine());

            orderCost = DRIVERS_WAGE + driversTip + (COST_OF_PIE * numberOfPies) + (COST_OF_TOPPING * amountOfToppings);

            Console.WriteLine("Your total is " + orderCost);
        }
    }
}