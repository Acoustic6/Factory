using Factory.Src.Pizzas;

namespace Factory.Src
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza MakePizza(string type)
        {
            Pizza pizza = null;
            
            switch(type)
            {
                case "Pepperoni":
                    pizza = new ChicagoStylePepperoniPizza();
                    break;
                case "Popular":
                    pizza = new ChicagoStylePopularPizza();
                    break;
                default:
                    pizza = new ChicagoStyleDefaultPizza();
                    break;
            }

            return pizza;
        }
    }
}