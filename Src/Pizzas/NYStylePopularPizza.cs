using System.Collections.Generic;

namespace Factory.Src.Pizzas
{
    public class NYStylePopularPizza: Pizza
    {
        public NYStylePopularPizza()
        {
            this.Name = "NY Popular Pizza";
            Dough = "NY Popular dough";
            Sauce = "NY Popular sauce";
            Toppings = new List<string> 
            {
                "NY Popular topping1",
                "NY Popular topping1"
            };
        }
    }
}