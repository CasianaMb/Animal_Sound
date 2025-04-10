using System;
using System.Collections.Generic;

namespace Animal_Sound
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new()
            {
                new Pig(),
                new Human(),
                new Dog()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetSoundMessage());
            }
        }
    }
}