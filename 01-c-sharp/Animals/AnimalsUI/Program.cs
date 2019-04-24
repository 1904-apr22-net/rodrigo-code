using Animals.Library;
using System;

namespace Animals.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //to access the class in the other project, I need a project reference
            // declaring and instantiating dog
            Dog dog = new Dog();
            dog.Name = "Bill";
            dog.Breed = "Labrador";
            dog.Bark();
            Console.WriteLine("Hello World!");
        }
    }
}
