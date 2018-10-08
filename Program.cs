using System;
using Factory.Src;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var NYStore = new NewYorkPizzaStore();
            var pizza1 = NYStore.OrderPizza("popular");
            var pizza2 = NYStore.OrderPizza("default");

            var chicagoStore = new ChicagoPizzaStore();
            chicagoStore.OrderPizza("pepperoni");
        }
    }
}
