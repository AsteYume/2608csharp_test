namespace _2608test;

public class Electronics : Goods
{
    public enum ElectronicsList
    {
        Battery,
        Codes
    }

    public ElectronicsList Electronic {get; set;}
    public Electronics(string name, int price, ElectronicsList elect) : base(name, price)
    {
        Electronic = elect;
    }
}