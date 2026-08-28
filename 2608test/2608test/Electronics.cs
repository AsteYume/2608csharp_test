namespace _2608test;

public class Electronics : Goods
{
    public enum ListElectronics
    {
        Battery,
        Code
    }
    public ListElectronics Electron {get; protected set;}
    
    public string Name { get; set; }
    public int BasePrice { get; set; }
    public int Price { get; set; }

    Electronics(string name, int baseprice, ListElectronics electron)
    {
        Name = name;
        BasePrice = baseprice;
        Electron = electron;
    }
    public void CalPrice()
    {
        Price = BasePrice;
    }
    

}