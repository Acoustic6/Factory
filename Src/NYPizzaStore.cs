using Factory.Src.Pizzas;

namespace Factory.Src
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore()
        {
            _factory = new NYIngridientFactory();
        }
        public override Pizza MakeCheesePizza(IIngridientFactory factory)
        {
            var pizza = base.MakeCheesePizza(_factory);
            pizza.SetName("New York cheese pizza");

            return pizza;
        }

        public override Pizza MakePepperoniPizza(IIngridientFactory factory)
        {
            var pizza = base.MakeCheesePizza(_factory);
            pizza.SetName("New York pepperoni pizza");

            return pizza;
        }
    }
}