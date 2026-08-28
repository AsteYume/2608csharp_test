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
    
    private static string _drinkName = "";
    private static int _drinkPrice = 0;
    
    public Drinks(ListDrinks drink) : base(_drinkName, _drinkPrice) 
    {
        Drink = drink;
        switch (drink)
        {
            case ListDrinks.Coke:
                _drinkName = "콜라";
                _drinkPrice = 1000;
                IsThisSale = true; // 열거형 두개에서 이름 일치하나 비교하는법 없나
                break;
            case ListDrinks.Cider:
                _drinkName = "사이다";
                _drinkPrice = 1000;
                IsThisSale = true;
                break;
            case ListDrinks.Coffee:
                _drinkName = "커피";
                _drinkPrice = 1500;
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
