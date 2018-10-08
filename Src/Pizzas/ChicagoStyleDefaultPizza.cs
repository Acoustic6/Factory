using System.Collections.Generic;

namespace Factory.Src.Pizzas
{
    public class ChicagoStyleDefaultPizza: Pizza
    {
        public ChicagoStyleDefaultPizza()
        {
            Name = "Chicago Default Pizza";
            Dough = "chicago default dough";
            Sauce = "chicago default sauce";
            Toppings = new List<string> 
            {
                "chicago default topping1",
                "chicago default topping1"
            };
        }
    }
}