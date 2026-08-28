namespace _2608test;

class Program
{
    static void Main(string[] args)
    {
        List<Goods> cart = new List<Goods>();
        List<Goods> shop = new List<Goods>();
        
        Drinks coke = new Drinks(Drinks.ListDrinks.Coke);
        Drinks cider = new Drinks(Drinks.ListDrinks.Cider);
        Drinks coffee = new Drinks(Drinks.ListDrinks.Coffee);
        Snacks chips = new Snacks(Snacks.ListSnacks.Chips);
        Snacks candy = new Snacks(Snacks.ListSnacks.Candy);
        Snacks choco = new Snacks(Snacks.ListSnacks.Chocolate);
        Snacks cookie = new Snacks(Snacks.ListSnacks.Cookie);
        Electronics battery = new Electronics("배터리", 3000, Electronics.ListElectronics.Battery);
        Electronics cable = new Electronics("케이블", 2000, Electronics.ListElectronics.Cable);

        





    }
}