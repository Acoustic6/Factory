using Factory.Src.Ingridients;
using Factory.Src.Ingridients.Cheese;
using Factory.Src.Ingridients.Pepper;
using Factory.Src.Ingridients.Pepperoni;

namespace Factory.Src
{
    public class NYIngridientFactory : IIngridientFactory
    {
        public Cheese CreateCheese()
        {
            return new NYCheese();
        }

        public Pepper CreatePepper()
        {
            return new NYPepper();
        }

        public Pepperoni CreatePepperoni()
        {
            return new NYPepperoni();
        }
    }
}