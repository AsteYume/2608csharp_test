namespace _2608test;

public enum DrinkList
{
    Coke,
    Cider,
    Juice,
    Coffee
}


public class Drinks : Foods
{
    public DrinkList Drink { get; protected set; }
    
    public Drinks(string name, int price, DrinkList drink) : base(name, price)
    {
        Drink = drink;
    }
}