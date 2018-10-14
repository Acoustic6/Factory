using System;
using Factory.Src;
using Factory.Src.Ingridients;
using Factory.Src.Pizzas;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var nYPizzaStore = new NYPizzaStore();
            var nyCheesePizza = nYPizzaStore.OrderPizza("cheese");

            var chicagoPizzaStore = new ChicagoPizzaStore();
            var chicagoPepperoniPizza = 
                chicagoPizzaStore.OrderPizza("pepperoni");
        }
    }
}
