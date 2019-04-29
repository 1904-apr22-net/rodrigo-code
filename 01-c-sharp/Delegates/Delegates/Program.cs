using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie = new Movie(){ Name = "Infinity War" };
            var moviePlayer = new MoviePlayer() { CurrentMovie = movie };
            // subscribe to event
            // first we need a method that should run when event occurs
            //
            MoviePlayer.PlayFinishedHandler handler = EjectDisc;

            moviePlayer.PlayFinished += handler;
            moviePlayer.Play();
        }

        static void EjectDisc()
        {
            Console.WriteLine("Ejecting the disc");
        }
    }
}
