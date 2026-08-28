namespace _2608test;

public enum DrinkList
{
    Coke,
    Cider,
    Juice,
    Coffee
}

public class Drinks : Goods, ICanSale
{
    
    public DrinkList Drink { get; protected set; }
    
    public bool IsThisSale {get; set;}
    public int SalePrice {get; set;}
    
    public Drinks(string name, int price, DrinkList drink) : base(name, price)
    {
        Drink = drink;
        if (drink == DrinkList.Coke
            || drink == DrinkList.Cider) // 이거 서로 다른 열거형에서 이름 일치하는지 비교 하는법 없나?
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