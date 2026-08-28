namespace _2608test;

class Program
{
    static void Main(string[] args)
    {
        List<Goods> cart = new List<Goods>();
        
        Drinks coke = new Drinks("콜라", 1000, Drinks.ListDrinks.Coke);
        Drinks cider = new Drinks("사이다", 1000, Drinks.ListDrinks.Cider);
        Drinks juice = new Drinks("주스",1500, Drinks.ListDrinks.Juice);
        Drinks coffee = new Drinks("커피",2000 , Drinks.ListDrinks.Coffee);
        Snacks chips = new Snacks("감자칩", 2000, Snacks.ListSnack.Chips);
        Snacks candy = new Snacks("사탕",500,Snacks.ListSnack.Candy);
        Snacks choco = new Snacks("초콜릿",3000,Snacks.ListSnack.Chocolate);
        Snacks cookie = new Snacks("쿠키",1500, Snacks.ListSnack.Cookie);
        Electronics battery = new Electronics("배터리", 3000, Electronics.ListElectronics.Battery);
        Electronics cable = new Electronics("케이블", 2000, Electronics.ListElectronics.Cable);
        
        





    }
}