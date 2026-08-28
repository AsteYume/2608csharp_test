namespace _2608test;

public abstract class Foods : Goods
{
    public string Name { get; set; }
    public int BasePrice { get; set; }
    public int Price {get; set;}
    public int Count {get; set;}
    public Foods(string name, int baseprice)
    {
        Name = name;
        BasePrice = baseprice;
        Count = 0;
    }

    public virtual void CalPrice()
    {
        Price = BasePrice;
    }

    public void Addgood()
    {
        Count++;
    }

    public void Removegood()
    {
        if (Count != 0)
        {
            Count--;
        }
        else
        {
            Console.WriteLine("카트에 해당 물품이 없습니다");
        }
    }
    
}