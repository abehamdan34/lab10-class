using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10MovieClass
{
    class Movies
    {
        private string title;
        private string category;
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
        public Movies()
        {
        }
        public Movies(string _title, string _category)
        {
            title = _title;
            category = _category;
        }
        private static List<string> GetListofMovieCategory(List<Movies> movieList)
        {
            List<string> movieCategory = new List<string>();
            foreach (Movies movie in movieList)
            {
                if (!movieCategory.Contains(movie.Category))
                {
                    movieCategory.Add(movie.Category);
                }
            }
            return movieCategory;
        }
        public static void PrintMovieCategory(List<Movies> movieList)
        {
            List<string> movieCategory = GetListofMovieCategory(movieList);
            foreach (string category in movieCategory)
            {
                Console.WriteLine($"{category}, ");
            }
        }
        public static void PrintMoviesByCategory(List<Movies> movieList, string categorySelected)
        {
            foreach (Movies movie in movieList)
            {
                if (categorySelected == movie.Category)
                {
                    Console.WriteLine($"{movie.title} \n");
                }
            }
        }
    }
}
