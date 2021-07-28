using System;
using PIZZASTORE.Stores;

namespace PIZZASTORE
{
    class Program
    {
        static void Main(string[] args)
        {
            var huePizzaStore = new HUEPizzaStore();
            huePizzaStore.OrderPizza("greek");
            var dnPizzaStore = new DNPizzaStore();
            dnPizzaStore.OrderPizza("cheese");
            var hcmPizzaStore = new HCMPizzaStore();
            hcmPizzaStore.OrderPizza("cheese");
        }
    }
}
