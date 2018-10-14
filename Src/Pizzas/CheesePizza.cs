using System;

namespace Factory.Src.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IIngridientFactory ingridientFactory)
        {
            _ingridientFactory = ingridientFactory;
        }
        public override void Prepare()
        {
            Cheese = _ingridientFactory.CreateCheese();
        }
    }
}