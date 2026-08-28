namespace _2608test;

public interface Goods
{
    protected string Name { get; set; }
    protected int BasePrice { get; set; }
    protected int Price { get; set; }
    protected int Count { get; set; }

    public void CalPrice();
    public void AddGood();
    public void RemoveGood();
    public void PrintInfo();
}