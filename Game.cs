using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Hutton_Riley
{
    class Game : IGenre
    {
        //Constructor that takes string parameters for Esrb, Genre, and Title
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        //Assigns the parameters to the corresponding properties
        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        //Prints that the game is starting
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ON!");
        }

        //Returns a string that describes the game
        public string Describe()
        {
            return $"{Title} is a(n) {Genre} game, rated {Esrb}!";
        }
    }
}
