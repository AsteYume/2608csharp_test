namespace _2608test;
using System.Collections.Generic;
public class GoodsStock<T> where T : Goods
{
    public List<Goods> GoodsList = new List<Goods>();




    

    /*public void NewGood(T goods)
    {
        GoodsList.Add(goods);
    }*/

    public void AddCart(int input)
    {
        Console.WriteLine(GoodsList[1]);
        GoodsList[input-1].AddCount();
    }

    /*public void RemoveCart(int input)
    {
        GoodsList[input].RemoveCount();
    }*/


    public void ClearCart()
    {
        GoodsList.Clear();
    }

    public void PrintMenu()
    {
        int i = 1;
        foreach (Goods goods in GoodsList)
        {
            Console.Write(i + ".");
            goods.PrintMenu();
            i++;
        }
    }

    public void PrintCarts()
    {
        foreach (Goods goods in GoodsList)
        {
            goods.PrintCart();
        }
    }

    public int CalculatePrice()
    {
        int sum = 0;
        foreach (Goods good in GoodsList)
        {
            sum += good.CalPrice();
        }
        return sum;
    }

    public void FillList()
    {
        GoodsList.Add(new Drinks(Drinks.ListDrinks.Coke));
        GoodsList.Add(new Drinks(Drinks.ListDrinks.Cider));
        GoodsList.Add(new Drinks(Drinks.ListDrinks.Coffee));
        GoodsList.Add(new Snacks(Snacks.ListSnacks.Chips));
        GoodsList.Add(new Snacks(Snacks.ListSnacks.Candy));
        GoodsList.Add(new Snacks(Snacks.ListSnacks.Chocolate));
        GoodsList.Add(new Snacks(Snacks.ListSnacks.Cookie));
        GoodsList.Add(new Electronics(Electronics.ListElectronics.CSubBattery));
        GoodsList.Add(new Electronics(Electronics.ListElectronics.Cable));
    }
    
}