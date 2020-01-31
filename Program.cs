using System;
using System.Collections.Generic;

namespace Lab10MovieClass
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            List<Movies> bestMoviesEver = new List<Movies>
            {
                new Movies("The Matrix" , "scifi"),
                new Movies("John Wick" , "action"),
                new Movies("Pulp Fiction" , "action"),
                new Movies("Step Brothers" , "comedy"),
                new Movies("Insidious" , "horror"),
                new Movies("Yes Man" , "comedy"),
                new Movies("The Conjuring" , "horror"),
                new Movies("Interstellar" , "scifi"),
                new Movies("Scream" , "horror"),
                new Movies("Bad Boys" , "action"),
            };
            while (repeat)
            {
                Movies.PrintMovieCategory(bestMoviesEver);
                string userInput = GetUserInput("Please choose a category! or e to exit");
                if (userInput == "e")
                {
                    break;
                }
                else if (userInput == "scifi")
                {
                    Console.WriteLine("");
                    Movies.PrintMoviesByCategory(bestMoviesEver, userInput);
                    repeat = RepeatOptions(repeat);
                }
                else if (userInput == "horror")
                {
                    Console.WriteLine("");
                    Movies.PrintMoviesByCategory(bestMoviesEver, userInput);
                    repeat = RepeatOptions(repeat);
                }
                else if (userInput == "action")
                {
                    Console.WriteLine("");
                    Movies.PrintMoviesByCategory(bestMoviesEver, userInput);
                    repeat = RepeatOptions(repeat);
                }
                else if (userInput == "comedy")
                {
                    Console.WriteLine("");
                    Movies.PrintMoviesByCategory(bestMoviesEver, userInput);
                    repeat = RepeatOptions(repeat);
                }
                else
                {
                    Console.WriteLine("Invalid input please try again!");
                }
            }
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static bool RepeatOptions(bool validate)
        {
            string userInput2 = GetUserInput("Would you like to repeat the options? y/n");
            if (userInput2 == "y")
            {
                validate = true;
            }
            else if (userInput2 == "n")
            {
                validate = false;
            }
            else
            {
                Console.WriteLine("Invalid input please try again!");
                validate = true;
            }
            return validate;

        }
    }
}
