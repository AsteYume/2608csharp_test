namespace _2608test;

public enum SnackList
{
    Chips,
    Cookie,
    Chocolate,
    Candy
}

public class Snacks : Foods
{
    public SnackList Snack { get; protected set; }
    
    public Snacks(string name, int price, SnackList snack) : base(name, price)
    {
        Snack = snack;
    }
}