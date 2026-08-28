namespace _2608test;

public interface Goods
{
    public string Name {get; protected set;}
    public int BasePrice {get; protected set;}

    public void CalPrice();
}