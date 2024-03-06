using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsCSharp.AbstractFactory
{
    public class AnimalFactory
    {
        public Animal GetAnimal(string animalType)
        {
            switch (animalType.ToLower())
            {
                case "dog":
                    return new Dog();
                case "cat":
                    return new Cat();
                default:
                    throw new ArgumentException("Invalid animal type");
            }
        }
    }
}
