namespace _2608test;

using System.Collections.Generic;
public class GoodsList<T> where T : Goods
{
    
    public static List<Goods> shop = new List<Goods>();
    public List<Goods> cart = new List<Goods>();
    


    public void AddCart(T goods)
    {
        if (cart.Contains(goods))
        {
            goods.AddGood();
        }
        else
        {
            cart.Add(goods);
        }
    }

    public void RemoveCart(T goods)
    {
        if (cart.Contains(goods))
        {
            goods.RemoveGood();
            if (cart.Count == 0)
            {
                cart.Remove(goods);
            }
        }
        else
        {
            Console.WriteLine("장바구니에 없는 물건입니다");
        }
    }
    
}