using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Console_Project_Dice_Rolls_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dice1;
            int dice2;
            int rollTotal;
            int total = 0;

            WriteLine("Chapter 10 Console Project Dice Rolls Array by Jared Tims\n");

            // dice talley array
            int[] diceCount = new int[12];
            // random number generator system constructor
            Random rng = new Random();
            // for loop that rolls two dice, adds them together and uses the array to keep
            // trach of the talley for each roll count.
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    dice1 = rng.Next(1, 7);
                    dice2 = rng.Next(1, 7);
                    rollTotal = dice1 + dice2;
                    diceCount[rollTotal - 1] += 1;
                    dice2 = 0;
                    dice1 = 0;
                    rollTotal = 0;
                    total = i + 1;
                }
                catch (IndexOutOfRangeException)
                {
                    WriteLine($"Index was outside of the bounds of the array. Index = {i}");
                }

            }
            // for loop that displays how many rolls for each number
            for (int i = 0; i < 12; i++)
            {
                WriteLine($"Number of rolls = {i + 1}: {diceCount[i]}");
            }
            // displays total rolls
            WriteLine($"Total number of rolls: {total}");

            WriteLine("\nPress any key to continue...");
            ReadKey();
        }
    }
}
