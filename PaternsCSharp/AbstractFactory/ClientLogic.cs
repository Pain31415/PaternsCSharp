using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsCSharp.AbstractFactory
{
    public class ClientLogic
    {
        private AnimalFactory animalFactory;

        public ClientLogic(AnimalFactory factory)
        {
            animalFactory = factory;
        }

        public void Run()
        {
            Animal dog = animalFactory.GetAnimal("dog");
            dog.Speak();

            Animal cat = animalFactory.GetAnimal("cat");
            cat.Speak();
        }
    }
}
