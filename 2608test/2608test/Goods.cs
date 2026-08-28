namespace _2608test;

public interface Goods
{
    protected string Name { get; set; }
    protected int BasePrice { get; set; }
    protected int Price { get; set; }
    protected int Count { get; set; }

    public int CalPrice();
    public void AddCount();
    // public void RemoveCount();
    public void PrintMenu();
    public void PrintCart();

}