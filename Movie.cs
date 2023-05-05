using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Hutton_Riley
{
    class Movie : IGenre
    {
        //Constructor that takes string parameters for Esrb, Genre, and Title
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        //Assigns the parameters to the corresponding properties
        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        //Prints that the movie is starting
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSSssssHHHHhhhh!");
        }

        //Returns a string that describes the game
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} movie, rated {Esrb}!";
        }
    }
}
