using Factory.Src.Ingridients.Cheese;
using Factory.Src.Ingridients.Pepperoni;
using Factory.Src.Ingridients.Pepper;

namespace Factory.Src
{
    public interface IIngridientFactory
    {
        Cheese CreateCheese();
        Pepperoni CreatePepperoni();
        Pepper CreatePepper();
    }
}