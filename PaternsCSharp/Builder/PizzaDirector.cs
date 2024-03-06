using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsCSharp.Builder
{
    public class PizzaDirector
    {
        private IPizzaBuilder pizzaBuilder;

        public PizzaDirector(IPizzaBuilder builder)
        {
            pizzaBuilder = builder;
        }

        public void MakePizza()
        {
            pizzaBuilder.SetDough("Thin");
            pizzaBuilder.SetSauce("Tomato");
            pizzaBuilder.SetTopping("Ham and Pineapple");
        }
    }
}
