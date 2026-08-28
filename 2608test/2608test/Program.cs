namespace _2608test;

class Program
{
    static void Main(string[] args)
    {
        int inCart = 0; // 카트에 몇개?
        bool isShopping = false; // 쇼핑중
        const string SHOP_NAME = "행복마트 천호점";
        ShoppingCart.
            
        
        
        shop.Add(new Drinks(Drinks.ListDrinks.Coke)); // 이거 열거형 불러와서 foreach 못넣나
        shop.Add(new Drinks(Drinks.ListDrinks.Cider));
        shop.Add(new Drinks(Drinks.ListDrinks.Coffee));
        shop.Add(new Snacks(Snacks.ListSnacks.Chips));
        shop.Add(new Snacks(Snacks.ListSnacks.Candy));
        shop.Add(new Snacks(Snacks.ListSnacks.Chocolate));
        shop.Add(new Snacks(Snacks.ListSnacks.Cookie));
        shop.Add(new Electronics(Electronics.ListElectronics.CSubBattery));
        shop.Add(new Electronics(Electronics.ListElectronics.Cable));
        
        isShopping = true;
        // while (isShopping)
        {
            Console.Clear();
            ConsolePrint.PrintCutLine();
            ConsolePrint.PrintKiosk(SHOP_NAME);
            ConsolePrint.PrintCutLine();
            ConsolePrint.PrintMenu("상품 목록");
            foreach (Goods goods in shop)
            {
                goods.PrintMenu();
            }
            ConsolePrint.PrintCutLine();
            if (inCart != 0)
            {
                ConsolePrint.PrintMenu("장바구니");
                foreach (Goods goods in cart)
                {
                    goods.PrintCart();
                }
                ConsolePrint.PrintCutLine();
            }

            int menuNumber = ConsoleInput.ReadIntInRange("1. 상품 추가   2. 상품 제거   3. 장바구니 비우기" +
                                                         "   4. 결제   5. 종료\n", 1, 5);
            switch (menuNumber)
            {
                case 1:
                {
                    int whatGoods = ConsoleInput.ReadIntInRange
                    ("1. 콜라   2. 사이다   3. 주스   4. 감자칩   5. 사탕   " +
                     "6. 초콜릿   7. 쿠키   8. 배터리   9. 케이블", 1, 9);
                    switch (whatGoods)
                    {
                        case 1:
                        {
                            cart.AddCart();
                        }
                        
                        
                        
                        
                    }




                    break;
                }
                case 2:
                {
                    break;
                }
                case 3:
                {
                    break;
                }
                case 4:
                {
                    break;
                }
                case 5:
                {
                    break;
                }
            }

        }


    }
}