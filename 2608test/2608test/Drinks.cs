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
    
    public Drinks(string name, int price, DrinkList drink) : base(name, price) 
    {
        Drink = drink;
        if (drink == DrinkList.Coke
            || drink == DrinkList.Cider) // 이거 서로 다른 열거형에서 이름 일치하는지 비교 하는법 없나?
            IsThisSale = true;
    }

    public override void CalPrice()
    {
        base.CalPrice();
    }
}
