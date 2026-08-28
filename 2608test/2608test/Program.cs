namespace _2608test;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool isShopping = false;
        List<Goods> shop = new List<Goods>();
        
        shop.Add(new Drinks(Drinks.ListDrinks.Coke)); // 이거 열거형 불러와서 foreach 못넣나
        shop.Add(new Drinks(Drinks.ListDrinks.Cider));
        shop.Add(new Drinks(Drinks.ListDrinks.Coffee));
        shop.Add(new Snacks(Snacks.ListSnacks.Chips));
        shop.Add(new Snacks(Snacks.ListSnacks.Candy));
        shop.Add(new Snacks(Snacks.ListSnacks.Chocolate));
        shop.Add(new Snacks(Snacks.ListSnacks.Cookie));
        shop.Add(new Electronics(Electronics.ListElectronics.CSubBattery));
        shop.Add(new Electronics(Electronics.ListElectronics.Cable));
        
        isShopping = true;
        // while (isShopping)
        {
            foreach (Goods goods in shop)
            {
                goods.PrintInfo();
            }
        }


    }
}