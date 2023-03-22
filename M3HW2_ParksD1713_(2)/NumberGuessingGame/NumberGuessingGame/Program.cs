
/**
* Date : 06 Mar 2023
* CSC 153
* Your Name: Daniel Parks
* Random number guessing game.
* 
* - Told to resubmit when I rework the porgram.
* - I could not get my previous application to work properly.
* - Reworked code for console application.
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Continuous While - Restart program/loop
            while (true)
            {
                // Identify random number
                Random random = new Random();
                int number = random.Next(1, 101);

                // Identify counter
                int count = 1;

                // evaluation loop
                while (true)
                {
                    // Take user input, convert to text
                    Console.Write("Please Guess a number from 1 to 100 :");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    // evaluate response.
                    if (guess == 0)
                    {
                        return;
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Too Low, try again.");
                        ++count;
                        continue;
                    }

                    else if (guess > number)
                    {
                        Console.WriteLine("Too high, try again.");
                        ++count;
                        continue;
                    }

                    // exit evaluation loop on complete
                    else
                    {
                        Console.WriteLine("Congrats! You guessed the number. " + number);
                        Console.WriteLine(count + " tries to guess the number.");
                        break;
                    }
                }
            }

        }

    }
}