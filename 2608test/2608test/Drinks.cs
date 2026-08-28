namespace _2608test;

public class Drinks : Foods
{
    public enum ListDrinks
    {
        Coke,
        Cider,
        Coffee
    }

    public ListDrinks Drink {get; protected set;}
    public bool IsThisSale {get; protected set;}
    
    private const int DRINK_SALE = 30;
    
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

    public override void CalPrice()
    {
        if (IsThisSale)
        {
            Price = (BasePrice * (100-DRINK_SALE))/100;
        }
        else
        {
            base.CalPrice();
        }
    }
    public override void PrintInfo()
    {
        Console.Write("음료 / ");
        Console.Write(Name + " ");
        Console.WriteLine(BasePrice + "원 ");
    }
    
}
