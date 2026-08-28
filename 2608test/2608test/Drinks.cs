namespace _2608test;

public class Drinks : Foods
{
    public enum ListDrinks
    {
        Coke = 1,
        Cider,
        Coffee
    }

    public ListDrinks Drink {get; protected set;}
    public bool IsThisSale {get; protected set;}
    
    private const int DRINK_SALE = 10;
    
    public Drinks(ListDrinks drink)
    {
        Drink = drink;
        switch (drink)
        {
            case ListDrinks.Coke:
                Name = "콜라";
                BasePrice = 1000;
                IsThisSale = true; // 열거형 두개에서 이름 일치하나 비교하는법 없나
                break;
            case ListDrinks.Cider:
                Name = "사이다";
                BasePrice = 1000;
                IsThisSale = true;
                break;
            case ListDrinks.Coffee:
                Name = "커피";
                BasePrice = 1500;
                IsThisSale = false;
                break;
        }
    }

    public override int CalPrice()
    {
        if (IsThisSale && Count >= 3)
        {
            Price = (BasePrice * (100-DRINK_SALE))/100;
        }
        else
        {
            Price = BasePrice;
        }
        Price *= Count;
        return Price;
    }
    public override void PrintMenu()
    {
        Console.Write(Name + " ");
        Console.Write(BasePrice + "원 ");
        Console.Write("/ 음료 ");
        if (IsThisSale)
        {
            Console.Write($"[3개 이상 구매시 {DRINK_SALE}% 할인중]");
        }
        Console.WriteLine();
    }
    
}
