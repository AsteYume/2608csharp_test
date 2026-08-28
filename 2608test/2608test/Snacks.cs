namespace _2608test;

public enum SnackList
{
    Chips,
    Cookie,
    Chocolate,
    Candy
}


public class Snacks : Goods, ICanSale
{
    
    public SnackList Snack { get; protected set; }
    public bool IsThisSale {get; set;}
    public int SalePrice {get; set;}
    
    public Snacks(string name, int price, SnackList snack) : base(name, price)
    {
        Snack = snack;
        if (snack == SnackList.Chips
            || snack == SnackList.Chocolate) // 이거 서로 다른 열거형에서 이름 일치하는지 비교 하는법 없나?
            IsThisSale = true;
        else
        {
            IsThisSale = false;
        }
    }
    
    public override void CalculatePrice()
    {
        if (IsThisSale)
        {
            CalSalePrice();
        }
        else
        {
            base.CalculatePrice();
        }
    }

    public void CalSalePrice()
    {
        SalePrice = ((BasePrice * SALE_RATE) / 100);
    }
    
}