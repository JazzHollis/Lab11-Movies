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


            bool repeat = true;
            while (repeat)
            {
                Console.Write("What movie category are you interested in? ");
                string category = Console.ReadLine();

                foreach (Movies m in MovieList)
                {
                    if (category.ToLower() == m.Category.ToLower())
                    {
                        m.PrintInfo();
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
