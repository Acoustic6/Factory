using System.Collections.Generic;

namespace Factory.Src.Pizzas
{
    public class NYStylePepperoniPizza: Pizza
    {
        public NYStylePepperoniPizza()
        {
            this.Name = "NY Pepperoni Pizza";
            Dough = "NY Pepperoni dough";
            Sauce = "NY Pepperoni sauce";
            Toppings = new List<string> 
            {
                "NY Pepperoni topping1",
                "NY Pepperoni topping1"
            };
        }
    }
}