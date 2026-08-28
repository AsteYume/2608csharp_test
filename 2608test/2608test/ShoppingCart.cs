namespace _2608test;

public class GoodsIndex<T> where T : Goods
{
    public List<Goods> Shop = new List<Goods>();


    public void AddCart(T goods)
    {
        if (Shop.Contains(goods))
        {
            goods.AddGood();
        }
        else
        {
            Shop.Add(goods);
        }
    }

    public void RemoveCart(T goods)
    {
        if (Shop.Contains(goods))
        {
            goods.RemoveGood();
            if (Shop.Count == 0)
            {
                Shop.Remove(goods);
            }
        }
        else
        {
            Console.WriteLine("장바구니에 없는 물건입니다");
        }
    }
    
}