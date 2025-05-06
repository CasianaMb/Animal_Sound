using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Sound.Animals
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string type)
        {
            return type.ToLower() switch
            {
                "dog" => new Dog(),
                "cat" => new Cat(),
                "cow" => new Cow(),
                "capybara" => new Capybara(),
                _ => throw new ArgumentException($"Unknown animal type: {type}")
            };
        }

        public static List<Animal> CreateAllAnimals()
        {
            return new List<Animal>
            {
                CreateAnimal("dog"),
                CreateAnimal("cat"),
                CreateAnimal("cow"),
                CreateAnimal("capybara")
            };
        }
    }
}
