using System;
using System.Collections.Generic;
using System.Linq;
using Cafe.Models;

namespace Cafe.Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Cafe");
            Console.WriteLine("A cup of coffee costs $" + Coffee.Price);
            Console.WriteLine("Every third cup of coffee is 50% off!");
            Console.WriteLine("Are you the owner of this Cafe?");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine("Okay, what do you want to set the price of coffee to?");
                int newCoffeePrice = int.Parse(Console.ReadLine());
                Coffee.Price = newCoffeePrice;
                Console.WriteLine("Done. The price of coffee is now $" + Coffee.Price);
            }
            else 
            {
                Console.WriteLine("Only the owner can change the price of coffee!");
            }

            Console.WriteLine("Would you like to order coffee? Price per cup is currently $" + Coffee.Price);
            Console.WriteLine("How many cups do you want? Every third cup is still 50% off!");
            int coffeeOrder = int.Parse(Console.ReadLine());
            Coffee userCoffee = new Coffee(coffeeOrder);
            Console.WriteLine("For " + userCoffee.Quantity + " cups of coffee your total is $" + userCoffee.CoffeeCost());
        }
    }
}