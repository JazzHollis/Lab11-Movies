using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Movie
{
    class Movies
    {
        #region Data Members
        private string title;
        private string category;
        #endregion

        #region Properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        #endregion


        #region Default constructor - Allows us to initialize the object
        public Movies()
        {

            title = "Movie Title";

        }
        #endregion

        #region Overloaded constructors
        public Movies(string movTitle, string movCategory)//These paramaters are settings provided
        {   //property name should always be on the left side
            title = movTitle;
            category = movCategory;
        }
        #endregion

        #region PrintInfo
        public void PrintInfo()
        {
            
            Console.WriteLine(Title);
        }
        #endregion
    }
}
