namespace Interfaces_Kohnen_Christian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game("E", "Platformer", "Mario");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("M", "Horror", "The Conjuring");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}