using System;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Guess_a_Number_
{
    class Program
    {
            static async Task Main()
            {
                await Task.Delay(1000);

                Console.WriteLine("Guess a Number! 1.0.0\n");




                await Task.Delay(1000);

                string text = "Welcome to the Guess a Number! (Made by Aruchomu).\n";

                foreach (char c in text)
                {
                    Console.Write(c);
                    await Task.Delay(80);
                }





                await Task.Delay(1000);

                string text1 = "\nThe rules are easy-peasy: AI picks some number and you need to guess it!";

                foreach (char c in text1)
                {
                    Console.Write(c);
                    await Task.Delay(80);
                }





                await Task.Delay(1000);

                string text3 = "\nAlso, you have only 1 attempt, because I don't feel like to give you more! ;)";

                foreach (char c in text3)
                {
                    Console.Write(c);
                    await Task.Delay(80);
                }






                await Task.Delay(1500);

                string text2 = "\n\nPlease, press any key to start.";

                foreach (char c in text2)
                {
                    Console.Write(c);
                    await Task.Delay(80);
                }






                var letter = Console.ReadKey();

                Console.Clear();






                Console.WriteLine("Please, guess a number from 0 to 100!:");




                int a = Random.Shared.Next(0, 101);

                int user_input;

            while (!int.TryParse(Console.ReadLine(), out user_input))   
            {
                Console.WriteLine("Invalid input. Please, enter your number again:");
            }


                if (a == user_input)
                {
                    await Task.Delay(4000);


                    string b = "Correct! You guessed the number!\nIt was " + a + "!";

                    foreach (char c in b)
                    {
                        Console.Write(c);
                        await Task.Delay(80);
                    }



                    Console.WriteLine("\n\nPress any key to exit...");

                    Console.ReadKey();
                }
                else
                {
                    await Task.Delay(4000);


                    string d = "NOPE! That's not it.\nIt was " + a + "!";

                    foreach (char c in d)
                    {
                        Console.Write(c);
                        await Task.Delay(80);
                    }



                    Console.WriteLine("\n\nPress any key to exit...");

                    Console.ReadKey();
                }
            }
        }
    }



