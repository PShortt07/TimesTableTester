using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimesTableTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RNG = new Random();
            Console.WriteLine("Welcome to the Times Table Tester! I am here to test you on your times tables from 1 to 12.");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            int num;
            int guess;
            int playAgain;
            int score = 0;
            int game = 0;
            while (game == 0)
            {
                do
                {
                    Console.WriteLine($"What times table (1-12) would you like to be tested on {name}?");
                    try
                    {
                        num = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Invalid.");
                        num = 0;
                    }
                } while (num > 12 || num < 1);
                for (int i = 0; i < 10; i++)
                {
                    int times = RNG.Next(1, 13);
                    int answer = num * times;
                    do
                    {
                        Console.WriteLine($"What is {num}x{times}?");
                        try
                        {
                            guess = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Invalid.");
                            guess = 0;
                        }
                    } while(guess == 0);
                    if (answer == guess)
                    {
                        Console.WriteLine("Correct!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.");
                    }
                }
                Console.WriteLine($"Your score was {score}");
                if (score >= 9)
                {
                    Console.WriteLine("Excellent!");
                }
                else if (score >= 7)
                {
                    Console.WriteLine("Pretty good!");
                }
                else if (score <=6)
                {
                    Console.WriteLine("You need a bit more practice!");
                }
                do
                {
                    Console.WriteLine("Enter 1 to play again or 0 to quit:");
                    try
                    {
                        playAgain = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Invalid.");
                        playAgain = 2;
                    }
                } while (playAgain  < 0 || playAgain > 1);
                if (playAgain == 1)
                {
                    game = 0;
                }
                else
                {
                    game = 1;
                }
            }
        }
    }
}
