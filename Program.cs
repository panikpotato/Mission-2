﻿//Write a .NET console application using C# that simulates the rolling of two 6-sided dice (NOTE:
//NOT a one 12-sided die.) Use an array to keep track of the number of times that each
//combination is thrown. In other words, keep track of how many times the combination of the two
//simulated dice is 2, how many times the combination is 3, and so on, all the way up through 12.
//Allow the user to choose how many times the “dice” will be thrown. Then, once you have that
//number of rolls, pass that number to a second class that has a method that simulates the roll of
//the dice for the number of times that the user specified. Store the results in an array. The method
//in the second class should return that array containing the roll results to the first class. In the first
//class, use that array to print a histogram (using the* character) that shows the total percentage
//each number was rolled. Each * will represent 1% of the total rolls.
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] history;
        Random random = new Random();

        int dice1 = random.Next(1, 7); // Generates a random number between 1 and 6
        int dice2 = random.Next(1, 7); // Generates a random number between 1 and 6

       
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?: ");
        string howmanydice = Console.ReadLine();
        

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS\r\nEach \"*\" represents 1% of the total number of rolls.\r\nTotal number of rolls = " + howmanydice + ".");
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!\r\n");
        
    }
}