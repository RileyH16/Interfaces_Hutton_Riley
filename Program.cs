using System;

namespace Interfaces_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            //Passes through the title, genre, and esrb arguments
            Game myGame = new Game("E", "FPS", "ZombCube");
            //Calls the describe method and prints to console
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            //Passes through the title, genre, and esrb arguments
            Movie myMovie = new Movie("PG", "Adventure/Comedy", "Sonic the Hedgehog 2");
            ////Calls the describe method and prints to console
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
