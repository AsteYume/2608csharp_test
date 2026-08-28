namespace _2608test;

public class ShoppingCart<T> where T : Goods
{
    List<Goods> Cart = new List<Goods>();


    public void Add(T goods)
    {
        if (Cart.Contains(goods))
        {
            goods.PlusGood();
        }
        else
        {
            Cart.Add(goods);
        }
    }

    public void Remove(T goods)
    {
        if (Cart.Contains(goods))
        {
            goods.MinusGood();
            if (Cart.Count == 0)
            {
                Cart.Remove(goods);
            }
        }
        else
        {
            Console.WriteLine("장바구니에 없는 물건입니다");
        }
    }
}