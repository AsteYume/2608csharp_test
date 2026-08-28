namespace _2608test;

public class Snacks : Foods
{
    public enum ListSnacks
    {
        Chips = 1,
        Chocolate,
        Candy,
        Cookie
    }
    public ListSnacks Snack {get; protected set;}
    public bool IsThisSale {get; protected set;}
    
    private const int SNACK_SALE = 20;
    
    public Snacks(ListSnacks snack)
    {
        Snack = snack;
        switch (snack)
        {
            case ListSnacks.Chips:
            {
                Name = "감자칩";
                BasePrice = 2000;
                IsThisSale = true;
                break;
            }
            case ListSnacks.Chocolate:
            {
                Name = "초콜릿";
                BasePrice = 3000;
                IsThisSale = true;
                break;
            }
            case ListSnacks.Candy:
            {
                Name = "사탕";
                BasePrice = 500;
                IsThisSale = false;
                break;
            }
            case ListSnacks.Cookie:
            {
                Name = "쿠키";
                BasePrice = 2500;
                IsThisSale = false;
                break;
            }
        }
        
    }

    public override int CalPrice()
    {
        if (IsThisSale&& Count >= 3)
        {
            Price = (BasePrice * (100-SNACK_SALE))/100;
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
        Console.Write("/ 과자 ");
        if (IsThisSale)
        {
            Console.Write($"[3개 이상 구매시 {SNACK_SALE}% 할인중]");
        }
        Console.WriteLine();
    }
    /*public ListSnacks ReutrnSnacks(int num)
    {
        switch (num)
        {
            case 1:
            {
                return ListSnacks.Chips;
            }
            case 2:
            {
                return ListSnacks.Chocolate;
            }
            case 3:
            {
                return ListSnacks.Candy;
            }
            case 4:
            {
                return ListSnacks.Cookie;
            }
        }

        return ListSnacks.Chips;
    }*/
}