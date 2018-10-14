using Factory.Src.Pizzas;

namespace Factory.Src
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza MakePizza(string type)
        {
            Pizza pizza = null;
            IIngridientFactory factory = new ChicagoIngridientFactory();

            switch (type.ToLower())
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.SetName("Chicago cheese pizza");
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(factory);
                    pizza.SetName("Chicago pepperoni pizza");
                    break;
            }
            return pizza;
        }
    }
}