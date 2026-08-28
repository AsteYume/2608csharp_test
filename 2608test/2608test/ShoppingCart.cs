namespace _2608test;

public class ShoppingCart<T> where T : Goods
{
    List<Goods> Cart = new List<Goods>();


    public void Add(T goods)
    {
        Cart.Add(goods);
    }

    public void Remove(T goods)
    {
        Cart.Remove(goods);
    }
}