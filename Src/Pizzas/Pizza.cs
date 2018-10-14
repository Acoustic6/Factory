using System;
using System.Collections.Generic;
using Factory.Src.Ingridients.Cheese;
using Factory.Src.Ingridients.Pepperoni;
using Factory.Src.Ingridients.Pepper;

namespace Factory.Src.Pizzas
{
    public abstract class Pizza
    {
        protected IIngridientFactory _ingridientFactory;
        private string _name;
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Pepper Pepper { get; set; }
        public List<string> Toppings { get; set; }

        public abstract void Prepare();

        public void SetName(string name)
        {
            _name = name;
        }

        public void Bake() =>  Console.WriteLine("Baking");
        public void Cut() =>  Console.WriteLine("Cutting");
        public void Box() => Console.WriteLine("Boxing");
    }
}