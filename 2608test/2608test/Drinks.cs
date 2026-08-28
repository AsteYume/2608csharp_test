namespace _2608test;

public class Drinks : Foods
{
    public enum DrinkList
    {
        Coke,
        Cider,
        Juice,
        Coffee
    }

    public DrinkList Drink {get; protected set;}

    Drinks(string Name, int BasePrice) : base(Name, BasePrice)
    {
        
    }
    
    






}