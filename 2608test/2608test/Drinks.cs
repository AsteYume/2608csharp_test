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
    public int salePrice {get; set;}
    
    public Drinks(string name, int price, bool isthissale, DrinkList drink) : base(name, price)
    {
        Drink = drink;
        if (drink == DrinkList.Coke
            || drink == DrinkList.Cider) // 이거 서로 다른 열거형에서 이름 일치하는지 비교 하는법 없나?
            isthissale = true;
        else
        {
            isthissale = false;
        }
    }

    public void CalculatePrice()
    {
    }

    public void CalSalePrice()
    {
    }
}