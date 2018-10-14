using Factory.Src.Ingridients;
using Factory.Src.Ingridients.Cheese;
using Factory.Src.Ingridients.Pepper;
using Factory.Src.Ingridients.Pepperoni;

namespace Factory.Src
{
    public class ChicagoIngridientFactory : IIngridientFactory
    {
        public Cheese CreateCheese()
        {
            return new ChicagoCheese();
        }

        public Pepper CreatePepper()
        {
            return new ChicagoPepper();
        }

        public Pepperoni CreatePepperoni()
        {
            return new ChicagoPepperoni();
        }
    }
}