namespace _2608test;

public class Electronics : Goods
{
    public enum ListElectronics
    {
        CSubBattery,
        Cable
    }
    public ListElectronics Electron {get; protected set;}
    
    public string Name { get; set; }
    public int BasePrice { get; set; }
    public int Price { get; set; }
    public int Count {get; set;}
    
    public Electronics(ListElectronics electron)
    {
        if (electron == ListElectronics.CSubBattery)
        {
            Name = "보조배터리";
            BasePrice = 3000;
        }
        else if (electron == ListElectronics.Cable)
        {
            Name = "충전케이블";
            BasePrice = 2000;
        }
    }
    public void CalPrice()
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

    public void PrintInfo()
    {
        Console.WriteLine("전자기기 / ");
        Console.Write(Name + " ");
        Console.Write(BasePrice + "원 ");
    }
}