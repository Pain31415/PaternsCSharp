using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaternsCSharp.Builder
{
    public interface IPizzaBuilder
    {
        void SetDough(string dough);
        void SetSauce(string sauce);
        void SetTopping(string topping);
        Pizza GetPizza();
    }
    public class HawaiianPizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza = new Pizza();

        public void SetDough(string dough)
        {
            pizza.Dough = dough;
        }

        public void SetSauce(string sauce)
        {
            pizza.Sauce = sauce;
        }

        public void SetTopping(string topping)
        {
            pizza.Topping = topping;
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }
}
