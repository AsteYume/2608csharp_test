namespace _2608test;

public abstract class Foods : Goods
{
    public string Name { get; set; }
    public int BasePrice { get; set; }
    public int Price {get; set;}
    public int Count {get; set;}
    public Foods()
    {
        Count = 0;
    }

    public virtual void CalPrice()
    {
        Price = BasePrice;
    }
    public void AddGood()
    {
        Count++;
    }
    public void RemoveGood()
    {
        Count--;
    }

    public abstract void PrintMenu();
    public void PrintCart()
    {
        if (Count == 0)
            return;
        Console.Write(Name + " ");
        Console.WriteLine(Count + "개 ");
    }

    public int ReturnCounts()
    {
        return Count;
    }
}