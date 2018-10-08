using Factory.Src.Pizzas;

namespace Factory.Src
{
    public class NewYorkPizzaStore : PizzaStore
    {
        public override Pizza MakePizza(string type)
        {
            Pizza pizza = null;
            
            switch(type)
            {
                case "Pepperoni":
                    pizza = new NYStylePepperoniPizza();
                    break;
                case "Popular":
                    pizza = new NYStylePopularPizza();
                    break;
                default:
                    pizza = new NYStyleDefaultPizza();
                    break;
            }

            return pizza;
        }
    }
}