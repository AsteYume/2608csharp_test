namespace _2608test;

public abstract class Foods : Goods
{
    public string Name { get; set; }
    public int BasePrice { get; set; }
    public int Price {get; set;}
    public Foods(string name, int baseprice)
    {
        Name = name;
        BasePrice = baseprice;
    }

    public virtual void CalPrice()
    {
        Price = BasePrice;
    }
    
}