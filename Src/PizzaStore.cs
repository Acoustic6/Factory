namespace Factory.Src
{
    public class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            switch(type)
            {
                case "Pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "Greek":
                    pizza = new GreekPizza();
                    break;
                default:
                    pizza = new DefaultPizza();
                    break;
            }

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;            
        }
    }
}