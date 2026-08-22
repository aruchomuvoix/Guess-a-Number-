using System;
using System.ComponentModel.Design;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Guess_a_Number_
{
    class Program
    {
        static async Task Typetext(string text, byte delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                await Task.Delay(delay);
            }
            return;
        }
           static async Task Main()
            {
                await Task.Delay(1000);

                Console.WriteLine("Guess a Number! 1.1.1\n");




                await Task.Delay(1000);
             
                string text = "Welcome to the Guess a Number! (Made by Aruchomu).\n";

                await Typetext(text, 80);





                await Task.Delay(1000);

                string text1 = "\nThe rules are easy-peasy: AI picks some number and you need to guess it!";

                await Typetext(text1, 80);





                await Task.Delay(1000);

                string text3 = "\nAlso, you have only 5 attempts, because I don't feel like to give you more! ;)";

                await Typetext(text3, 80);





                await Task.Delay(1500);

                string text2 = "\n\nPlease, press any key to start.\n";

                await Typetext(text2, 80);






                var letter = Console.ReadKey();

                Console.Clear();






                Console.WriteLine("Please, guess a number from 0 to 100!:");




                int a = Random.Shared.Next(0, 101);

                int user_input;






                while (!int.TryParse(Console.ReadLine(), out user_input) || user_input < 0 || user_input > 100)
                {
                   Console.WriteLine("Invalid input. Please, enter your number again:");
                }












                byte attempts = 5;

                while (attempts > 0)
                {


                if (a == user_input)
                {
                    await Task.Delay(4000);


                    string b = $"Correct! You guessed the number!\nIt was {a}!";

                    await Typetext(b, 80);

                    

                    break;
                }
                else
                {
                    attempts--;


                    if (attempts > 0)
                    {
                        await Task.Delay(4000);

                        string k = $"Nopey! You have {attempts} attempts left.\nPlease, enter your number again:";
                        await Typetext(k, 80);

                        while (!int.TryParse(Console.ReadLine(), out user_input) || user_input < 0 || user_input > 100)
                        {
                            Console.WriteLine("Invalid input. Please, enter your number again:\n");
                        }
                    }
                    else
                    {
                        await Task.Delay(4000);
                        string d = $"NOPE! That's not it.\nIt was {a}!";
                        await Typetext(d, 80);
                    }

                
                }




                
            }

            Console.WriteLine("\n\nPress any key to exit...");

            Console.ReadKey();
        }
        }
    }



