namespace PIZZASTORE
{
    public abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            if(pizza == null)
                return;
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
