namespace _2608test;

public abstract class Foods : Goods
{
    public string Name { get; set; }
    public int BasePrice { get; set; }
    public int Price {get; protected set;}
    public bool IsThisSale { get; protected set; }

    Foods(string name, int price, bool isThisSale)
    {
        Name = name;
        Price = price;
        IsThisSale = isThisSale;
    }

    public virtual void CalPrice()
    {
        Price = BasePrice;
    }
    
}