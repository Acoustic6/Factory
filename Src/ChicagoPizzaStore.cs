using Factory.Src.Pizzas;

namespace Factory.Src
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore()
        {
            _factory = new ChicagoIngridientFactory();
        }

        public override Pizza MakeCheesePizza(IIngridientFactory factory)
        {
            var pizza = base.MakeCheesePizza(_factory);
            pizza.SetName("Chicago cheese pizza");

            return pizza;
        }

        public override Pizza MakePepperoniPizza(IIngridientFactory factory)
        {
            var pizza = base.MakeCheesePizza(_factory);
            pizza.SetName("Chicago pepperoni pizza");

            return pizza;
        }
    }
}