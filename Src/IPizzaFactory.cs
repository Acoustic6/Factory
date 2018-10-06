namespace Factory.Src
{
    public interface IPizzaFactory
    {
        Pizza MakePizza(string type);
    }
}