using System.Collections.Generic;

namespace Factory.Src.Pizzas
{
    public class NYStyleDefaultPizza: Pizza
    {
        public NYStyleDefaultPizza()
        {
            this.Name = "NY Default Pizza";
            Dough = "NY default dough";
            Sauce = "NY default sauce";
            Toppings = new List<string> 
            {
                "NY default topping1",
                "NY default topping1"
            };
        }
    }
}