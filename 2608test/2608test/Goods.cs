namespace _2608test;

public abstract class Goods
{
    public const int SALE_RATE = 20;
    public string Name { get; protected set; }
    public int BasePrice {get; protected set;}
    
    public bool isThisSale {get; set;}
    public int salePrice {get; set;}
    

    public Goods(string name, int price)
    {
        Name = name;
        BasePrice = price;
    }

    public void CalSalePrice()
    {
        salePrice = (BasePrice * (100 - SALE_RATE)) / 100;
    }
}