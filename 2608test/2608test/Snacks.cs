namespace _2608test;

public class Snacks : Foods
{
    public enum ListSnacks
    {
        Chips,
        Chocolate,
        Candy,
        Cookie
    }
    public ListSnacks Snack {get; protected set;}
    public bool IsThisSale {get; protected set;}
    
    private const int SNACK_SALE = 20;
    
    private static string _snackName = "";
    private static int _snackPrice = 0;
    
    public Snacks(ListSnacks snack) : base(_snackName, _snackPrice) 
    {
        Snack = snack;
        if (snack == ListSnacks.Chips)
        {
            _snackName = "감자칩";
            _snackPrice = 2000;
            IsThisSale = true;
        }
        else if (snack == ListSnacks.Chocolate)
        {
            _snackName = "초콜릿";
            _snackPrice = 3000;
            IsThisSale = true;
        }
        else if (snack == ListSnacks.Candy)
        {
            _snackName = "사탕";
            _snackPrice = 500;
            IsThisSale = false;
        }
        else if (snack == ListSnacks.Cookie)
        {
            _snackName = "쿠키";
            _snackPrice = 2500;
            IsThisSale = false;
        }
    }

    public override void CalPrice()
    {
        if (IsThisSale)
        {
            Price = (BasePrice * (100-SNACK_SALE))/100;
        }
        else
        {
            base.CalPrice();
        }
    }
    public override void PrintInfo()
    {
        Console.WriteLine("과자 / ");
        Console.Write(Name + " ");
        Console.Write(BasePrice + "원 ");
    }
}