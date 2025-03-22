using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission02;

internal class Class1()
{

    public int[] RollDice(int number_of_rolls)
    {
        //THIS IS FOR TESTING
        //Console.WriteLine("the RollDice method is being accessed...");

        int[] counter = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


        // for loop
        for (int i = 0; i < number_of_rolls; i++)
        {
            // geneate random number
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            int num = dice1 + dice2;


            counter[num - 2] = counter[num - 2] + 1;
        }

        // THIS IS FOR TESTING
        //foreach (var item in counter)
        //{
        //    Console.WriteLine(item.ToString());
        //}

        return counter;
    }
}