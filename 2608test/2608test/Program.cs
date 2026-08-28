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
        Snacks chips = new Snacks("감자칩", 2000, Snacks.ListSnack.Chips);
        Snacks candy = new Snacks("사탕",500,Snacks.ListSnack.Candy);
        Snacks choco = new Snacks("초콜릿",3000,Snacks.ListSnack.Chocolate);
        Snacks cookie = new Snacks("쿠키",1500, Snacks.ListSnack.Cookie);
        Electronics battery = new Electronics("배터리", 3000, Electronics.ListElectronics.Battery);
        Electronics cable = new Electronics("케이블", 2000, Electronics.ListElectronics.Cable);

        





    }
}