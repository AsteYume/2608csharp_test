namespace _2608test;

public abstract class Goods
{
    public const int SALE_RATE = 20;
    public string Name { get; protected set; }
    public int BasePrice {get; protected set;}
    public int Price {get; protected set;}

    public Goods(string name, int price)
    {
        Name = name;
        BasePrice = price;
    }

    public virtual void CalculatePrice()
    {
        Price = BasePrice;
    }
    
}