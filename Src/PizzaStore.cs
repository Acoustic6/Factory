namespace Factory.Src
{
    public class PizzaStore
    {
        private IPizzaFactory pizzaFactory;
        public PizzaStore(IPizzaFactory _pizzaFactory) 
            => pizzaFactory = _pizzaFactory;
        
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = pizzaFactory.MakePizza(type);
            
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;            
        }
    }
}