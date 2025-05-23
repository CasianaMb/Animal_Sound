﻿using System;
using System.Collections.Generic;
using Animal_Sound.Animals;

namespace Animal_Sound
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = AnimalFactory.CreateAllAnimals();

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
            }

            Console.ReadLine();
        }
    }
}
