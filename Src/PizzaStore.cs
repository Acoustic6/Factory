using Factory.Src.Pizzas;

namespace Factory.Src
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = MakePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;            
        }

        public abstract Pizza MakePizza(string type);
        
    }
}