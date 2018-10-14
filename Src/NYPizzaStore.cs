using Factory.Src.Pizzas;

namespace Factory.Src
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza MakePizza(string type)
        {
            Pizza pizza = null;
            IIngridientFactory factory = new NYIngridientFactory();

            switch (type.ToLower())
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.SetName("New Yorks cheese pizza");
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(factory);
                    pizza.SetName("New York cheese pizza");
                    break;
            }
            return pizza;
        }
    }
}