using System.Collections.Generic;

namespace Factory.Src.Pizzas
{
    public class ChicagoStylePopularPizza: Pizza
    {
        public ChicagoStylePopularPizza()
        {
            this.Name = "Chicago Popular Pizza";
            Dough = "chicago Popular dough";
            Sauce = "chicago Popular sauce";
            Toppings = new List<string> 
            {
                "chicago Popular topping1",
                "chicago Popular topping1"
            };
        }
    }
}