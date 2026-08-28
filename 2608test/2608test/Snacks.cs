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
    public bool isThisSale {get; set;}
    public int salePrice {get; set;}
    public SnackList Snack { get; protected set; }
    
    public Snacks(string name, int price, SnackList snack) : base(name, price)
    {
        Snack = snack;
    }
    
}