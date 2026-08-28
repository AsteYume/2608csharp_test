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
        if (Cart.Contains(goods))
        {
            Cart.Remove(goods);
        }
        else
        {
            Console.WriteLine("장바구니에 해당 상품이 없습니다");
        }

    }
}