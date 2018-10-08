using System.Collections.Generic;

namespace Factory.Src.Pizzas
{
    public class ChicagoStylePepperoniPizza: Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            this.Name = "Chicago Pepperoni Pizza";
            Dough = "chicago Pepperoni dough";
            Sauce = "chicago Pepperoni sauce";
            Toppings = new List<string> 
            {
                "chicago Pepperoni topping1",
                "chicago Pepperoni topping1"
            };
        }
    }
}