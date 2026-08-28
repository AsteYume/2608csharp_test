namespace _2608test;

public abstract class Foods : Goods
{
    public string Name { get; set; }
    public int BasePrice { get; set; }
    public int Price {get; protected set;}
    public bool IsThisSale { get; protected set; } = false;

    public Foods(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public virtual void CalPrice()
    {
        Price = BasePrice;
    }
    
}