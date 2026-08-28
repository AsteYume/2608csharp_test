namespace _2608test;

public class Drinks : Foods
{
    public enum ListDrinks
    {
        Coke,
        Cider,
        Juice,
        Coffee
    }

    public ListDrinks Drink {get; protected set;}
    public bool IsThisSale {get; protected set;}
    private const int DRINK_SALE = 30;
    
    
    public Drinks(string name, int baseprice, ListDrinks drink) : base(name, baseprice) 
    {
        Drink = drink;
        if (drink == ListDrinks.Coke
            || drink == ListDrinks.Cider) // 이거 서로 다른 열거형에서 이름 일치하는지 비교 하는법 없나?
            IsThisSale = true;
        else 
            IsThisSale = false;
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
        Console.WriteLine("음료 / ");
        Console.Write(Name + " ");
        Console.Write(BasePrice + "원 ");
    }
    
}
