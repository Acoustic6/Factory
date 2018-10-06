namespace Factory.Src
{
    public class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();
            
            Pizza pizza = pizzaFactory.MakePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;            
        }
    }
}