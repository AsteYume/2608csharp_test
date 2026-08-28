namespace _2608test;

public interface Goods
{
    protected string Name { get; set; }
    protected int BasePrice { get; set; }
    protected int Price { get; set; }

    public void CalPrice();
}