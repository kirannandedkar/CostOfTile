using System;

namespace CostOfTile
{
    internal class Program
    {
        //Description: Ask the user to enter in width, length, and the cost per 1 unit of flooring.Have the program calculate how much it would cost to cover the area specified with the flooring.

        // Added Difficulty: Calculate how much flooring would be needed for non-rectangular rooms.
        // Also figure out how much labor costs would be given that the average flooring team can only put in 20 square feet of flooring per hour at a cost of $86.00/hr
        static double costPerHour = 86;
        static int flooringPerHour = 20;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome. Lets calculate price of tile!");
            CalculatePriceOfTile();
        }

        static void CalculatePriceOfTile()
        {
            Console.WriteLine("Press 1 to select rectangle and Press 2 to select Triangle");
            string input = Console.ReadLine();
            Console.WriteLine("Please enter length");
            int length = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter Width");
            int width = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter price per tile");
            decimal tilePrice = Convert.ToInt16(Console.ReadLine());
            int area = CalculateArea(input, length, width);
            decimal priceOfTile = area * tilePrice;
            Console.WriteLine($"Price of tiles is {priceOfTile}");
            Console.WriteLine($"Labour cost per hour is {LabourCostPerHour(area)}");

            
            static int CalculateArea(string shape, int length, int width)
            {
                if (shape == "1")//Rectangle
                {
                    return length * width;
                }
                else //Triangle
                {
                    return (length * width) / 2;
                }
            }

            static double LabourCostPerHour(int area)
            {
                return (double) area / flooringPerHour *  costPerHour;
            }


        }
    }
}
