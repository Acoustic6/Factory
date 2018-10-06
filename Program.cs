using System;
using Factory.Src;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaFactory simplePizzaFactory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(simplePizzaFactory);
            pizzaStore.OrderPizza("popular");
        }
    }
}
