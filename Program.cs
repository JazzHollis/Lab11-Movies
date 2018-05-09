﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiation
            List<Movies> MovieList = new List<Movies>();

            MovieList.Add(new Movies("The Matrix", "Sci-Fi"));
            MovieList.Add(new Movies("When Harry Met Sally", "Romance"));
            MovieList.Add(new Movies("Bad Boys", "Action"));
            MovieList.Add(new Movies("Bone Collector", "Crime"));
            MovieList.Add(new Movies("Coming To America", "Comedy"));
            MovieList.Add(new Movies("The Color Purple", "Drama"));
            MovieList.Add(new Movies("The Notebook", "Romance"));
            MovieList.Add(new Movies("Sugar Hill", "Crime"));
            MovieList.Add(new Movies("Up", "Animation"));
            MovieList.Add(new Movies("Despicable Me", "Animation"));

            //Creation of Categories 
            string[] Categories =  { "Sci-Fi", "Romance", "Action", "Crime", "Drama", "Animation" };


            bool repeat = true;
            while (repeat)//Loop to continue playing
            {
                Console.WriteLine("What movie category are you interested in? \n(1)Sci-Fi (2)Comedy (3)Romance (4)Crime (5)Animation");

                int MovieChoice;
                while
                (!int.TryParse(Console.ReadLine(), out MovieChoice) || MovieChoice < 1 || MovieChoice > 5)//Validation to ensure correct input is given
                {
                    Console.WriteLine("Invalid input, please enter a number from the option list.");
                }
                foreach (Movies m in MovieList )//Refers to Movies class file and retrieves elements in
                                                //MovieList that are assigned to the users requested category
                {
                    if (Categories[MovieChoice-1] == m.Category)//condition compares user input to Movies Class file - Category Property
                    {
                        m.PrintInfo();//Prints element that meets criteria
                    }
                    
                }

                Console.Write("Would you like to select another category?(y/n)");
                string input = Console.ReadLine().ToLower();


                if (input == "y")
                {
                    repeat = true;
                }

                else
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
           

            }

        }
    }
}
