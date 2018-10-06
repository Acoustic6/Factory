namespace Factory.Src
{
    public class SimplePizzaFactory
    {
        public Pizza MakePizza(string type)
        {
            Pizza pizza;

            switch(type)
            {
                case "Pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "Popular":
                    pizza = new PopularPizza();
                    break;
                default:
                    pizza = new DefaultPizza();
                    break;
            }

            return pizza;
        }
    }
}