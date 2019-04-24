using System;
using System.Collections.Generic;
using System.Text;
using Animals.UI;

namespace Animals.Library
{
    public class Dog
    {
        public string Breed { get; set; }
        public string Name { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
    }
}
