using Factory.Src.Pizzas;

namespace Factory.Src
{
    public abstract class PizzaStore
    {
        protected IIngridientFactory _factory;
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = MakePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;            
        }
        protected Pizza MakePizza(string type)
        {
            Pizza pizza = null;

            switch (type.ToLower())
            {
                case "cheese":
                pizza = MakeCheesePizza(_factory);
                    break;
                case "pepperoni":
                    pizza = MakePepperoniPizza(_factory);
                    break;
            }
            return pizza;
        }

        public virtual Pizza MakeCheesePizza(IIngridientFactory factory)
        {
            return new CheesePizza(factory);
        }
        public virtual Pizza MakePepperoniPizza(IIngridientFactory factory)
        {
            return new PepperoniPizza(factory);
        }
    }
}