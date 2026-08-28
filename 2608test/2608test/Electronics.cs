namespace _2608test;

public class Electronics : Goods
{
    public enum ListElectronics
    {
        CSubBattery = 1,
        Cable
    }
    public ListElectronics Electron {get; protected set;}
    
    public string Name { get; set; }
    public int BasePrice { get; set; }
    public int Price { get; set; }
    public int Count {get; set;}
    
    public Electronics(ListElectronics electron)
    {
        Electron = electron;
        Count = 0;
        switch (electron)
        {
            case ListElectronics.CSubBattery:
            {
                Name = "보조배터리";
                BasePrice = 3000;
                break;
            }
            case ListElectronics.Cable:
            {
                Name = "충전케이블";
                BasePrice = 2000;
                break;
            }
        }
    }
    public int CalPrice()
    {
        Price = BasePrice;
        Price *= Count;
        return Price;
    }
    public void AddCount()
    {
        Count++;
    }
    /*public void RemoveCount()
    {
        Count--;
    }*/

    public void PrintMenu()
    {
        Console.Write(Name + " ");
        Console.Write(BasePrice + "원 ");
        Console.WriteLine("/ 전자기기 ");
        
    }
    public void PrintCart()
    {
        if (Count == 0)
            return;
        Console.Write(Name + " ");
        Console.WriteLine(Count + "개 ");
    }
    /*public ListElectronics ReutrnElectron(int num)
    {
        switch (num)
        {
            case 1:
            {
                return ListElectronics.CSubBattery;
            }
            case 2:
            {
                return ListElectronics.Cable;
            }
        }

        return ListElectronics.CSubBattery;
    }*/
}