namespace _2608test;

public enum DrinkList
{
    Coke,
    Cider,
    Juice,
    Coffee
}

public enum SaleList
{
    Coke,
    Cider
}


public class Drinks : Goods, ICanSale
{
    public DrinkList Drink { get; protected set; }
    
    public Drinks(string name, int price, DrinkList drink) : base(name, price)
    {
        Drink = drink;
    }
    
    
    
}