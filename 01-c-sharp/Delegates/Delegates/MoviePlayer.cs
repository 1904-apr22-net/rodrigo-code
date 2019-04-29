using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class MoviePlayer
    {
        public Movie CurrentMovie{ get; set; }

        public delegate void PlayFinishedHandler();

        public event PlayFinishedHandler PlayFinished;


        public void Play()
        {
            Console.WriteLine("Playing inserted movie " + CurrentMovie.Name);

            //starting interpolation sequence
            Thread.Sleep(3000);
            PlayFinished();
        }

    }

    
}
