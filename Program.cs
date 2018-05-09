using System;
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
            string[] Categories = { "Sci-Fi", "Comedy", "Romance", "Crime", "Drama", "Animation","Action"};


             
            bool repeat = true;
            while (repeat)//Loop to continue playing
            {
                Console.WriteLine("What movie category are you interested in? \n(1)Sci-Fi (2)Comedy (3)Romance (4)Crime (5)Drama (6)Animation (7)Action");

                int MovieChoice;
                while
                (!int.TryParse(Console.ReadLine(), out MovieChoice) || MovieChoice < 1 || MovieChoice > 7)//Validation to ensure correct input is given
                {
                    Console.WriteLine("Invalid input, please enter a number from the option list.");
                }
                foreach (Movies m in MovieList)//Refers to Movies class file and retrieves elements in
                                               //MovieList that are assigned to the users requested category
                {
                    if (Categories[MovieChoice - 1] == m.Category)//condition compares user input to Movies Class file - Category Property
                    {
                        m.PrintInfo();//Prints element that meets criteria
                    }

                }
                

                bool anotherChoice = PlayAgain("Would you like to select another category?(y/n)");
            }
        }

        public static bool PlayAgain(string response)

        {
            Console.WriteLine(response);

            string input = Console.ReadLine().ToLower();

            while (true)

            {

                if (input == "y")

                {
                    return true;
                }

                else if (input == "n")

                {
                    Console.WriteLine("Goodbye!");
                    return false;
                }

                else

                {
                    Console.WriteLine("Invalid input. Please select (y/n) to choose another category");
                   
                }
            }

   

        }
    }
}
             

