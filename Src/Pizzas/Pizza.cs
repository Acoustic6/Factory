using System;
using System.Collections.Generic;

namespace Factory.Src.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough");
            Console.WriteLine("Adding sauce");
            foreach(var topping in Toppings)
                Console.WriteLine("Adding toping: " + topping);
        }

        public void Bake() =>  Console.WriteLine("Baking");
        public void Cut() =>  Console.WriteLine("Cutting");
        public void Box() => Console.WriteLine("Boxing");
    }
}