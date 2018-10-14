using System;

namespace Factory.Src.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IIngridientFactory ingridientFactory)
        {
            _ingridientFactory = ingridientFactory;
        }

        public override void Prepare()
        {
            Cheese = _ingridientFactory.CreateCheese();
            Pepperoni = _ingridientFactory.CreatePepperoni();
            Pepper = _ingridientFactory.CreatePepper();
        }
    }
}