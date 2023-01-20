using System;

namespace CostOfTile
{
    internal class Program
    {
        //Description: Ask the user to enter in width, length, and the cost per 1 unit of flooring.Have the program calculate how much it would cost to cover the area specified with the flooring.

        // Added Difficulty: Calculate how much flooring would be needed for non-rectangular rooms.
        // Also figure out how much labor costs would be given that the average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome. Lets calculate price of tile!");
        }

        static void CalculatePriceOfTile()
        {
            Console.WriteLine("Please enter length");
            int length = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter Width");
            int width = Convert.ToInt16(Console.ReadLine());

            int area = length * width;

            Console.WriteLine("Please enter price per tile");
            int tilePrice = Convert.ToInt16(Console.ReadLine());

            int priceOfTile = area * tilePrice;
            Console.WriteLine($"Price of tiles is {priceOfTile}");




        }
    }
}
