//Write a .NET console application using C# that simulates the rolling of two 6-sided dice (NOTE:
//NOT a one 12-sided die.) Use an array to keep track of the number of times that each
//combination is thrown. In other words, keep track of how many times the combination of the two
//simulated dice is 2, how many times the combination is 3, and so on, all the way up through 12.
//Allow the user to choose how many times the “dice” will be thrown. Then, once you have that
//number of rolls, pass that number to a second class that has a method that simulates the roll of
//the dice for the number of times that the user specified. Store the results in an array. The method
//in the second class should return that array containing the roll results to the first class. In the first
//class, use that array to print a histogram (using the* character) that shows the total percentage
//each number was rolled. Each * will represent 1% of the total rolls.
using System.Diagnostics.Metrics;

namespace mission02;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine();
        Console.Write("How many dice rolls would you like to simulate?  ");
        string userInput = Console.ReadLine();
        //turn string to int
        int number_of_rolls = int.Parse(userInput);
        //int number_of_rolls = Convert.ToInt32(Console.ReadLine());

        //call nect class
        Class1 test = new Class1();
        int[] test2 = test.RollDice(number_of_rolls);
        //start lable
        int lable = 2;

        Console.WriteLine();
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each ''*'' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + number_of_rolls);
        Console.WriteLine();

        // loop through the returned array
        foreach (var item in test2)
        {
            //find percent
            int percent = item * 100 / number_of_rolls;

            Console.Write(lable + ": ");

            //print a star for each percent
            for (int i = 0; i < percent; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            // advance lable
            lable = lable + 1;

        }
        Console.WriteLine();
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}