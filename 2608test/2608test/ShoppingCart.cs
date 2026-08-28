namespace _2608test;

public class GoodsIndex<T> where T : Goods
{
    List<Goods> Cart = new List<Goods>();


    public void AddCart(T goods)
    {
        if (Cart.Contains(goods))
        {
            goods.AddGood();
        }
        else
        {
            Cart.Add(goods);
        }
    }

    public void RemoveCart(T goods)
    {
        if (Cart.Contains(goods))
        {
            goods.RemoveGood();
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