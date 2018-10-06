namespace Factory.Src
{
    public class SimplePizzaFactory : IPizzaFactory
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