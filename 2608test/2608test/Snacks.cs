namespace _2608test;

public class Snacks : Foods
{
    public enum SnackList
    {
        Chips,
        Chocolate,
        Candy,
        Cookie
    }
    public SnackList Snack {get; protected set;}
    public bool IsThisSale {get; protected set;}
    private const int SNACK_SALE = 20;
    
    
    public Snacks(string name, int baseprice, SnackList snack) : base(name, baseprice) 
    {
        Snack = snack;
        if (snack == SnackList.Chips
            || snack == SnackList.Chocolate) // 이거 서로 다른 열거형에서 이름 일치하는지 비교 하는법 없나?
            IsThisSale = true;
        else 
            IsThisSale = false;
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
}