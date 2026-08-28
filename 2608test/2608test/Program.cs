namespace _2608test;

class Program
{
    static void Main(string[] args)
    {
        int inCart = 0; // 카트에 몇개?
        int finalPrice = 0;
        int paiedPrice = 0;
        int whatGoods;
        bool isPaying = false;
        bool isShopping = false; // 쇼핑중
        const string SHOP_NAME = "행복마트 천호점";

        
        GoodsStock<Goods> shop = new GoodsStock<Goods>();
        
        shop.FillList();
        
        isShopping = true;
        while (isShopping)
        {
            Console.Clear();
            ConsolePrint.PrintCutLine();
            ConsolePrint.PrintKiosk(SHOP_NAME);
            ConsolePrint.PrintCutLine();
            ConsolePrint.PrintTitle("상품 목록");
            shop.PrintMenu();
            ConsolePrint.PrintCutLine();
            if (inCart != 0)
            {
                ConsolePrint.PrintTitle("장바구니");
                shop.PrintCarts();
                ConsolePrint.PrintCutLine();
            }

            int menuNumber = ConsoleInput.ReadIntInRange("1. 상품 추가   2. 장바구니 비우기" +
                                                         "   3. 결제   4. 종료\n", 1, 4);
            switch (menuNumber)
            {
                case 1:
                {
                    whatGoods = ConsoleInput.ReadIntInRange
                        ("상품 번호를 입력해주세요\n", 1, 9);
                    shop.AddCart(whatGoods);
                    inCart++;
                    break;
                }
                case 2:
                {
                    shop.ClearCart();
                    inCart = 0;
                    shop.FillList();
                    break;
                }
                case 3:
                {
                    finalPrice = shop.CalculatePrice();
                    isPaying = finalPrice > 0 ? true : false;
                    isShopping = false;
                    break;
                }
                case 4:
                {
                    finalPrice = shop.CalculatePrice();
                    isPaying = finalPrice > 0 ? true : false;
                    isShopping = false;
                    break;
                }
            }
        }
        if (isPaying)
        {
            while (isPaying)
            {
                Console.Clear();
                ConsolePrint.PrintCutLine();
                ConsolePrint.PrintKiosk(SHOP_NAME);
                ConsolePrint.PrintCutLine();
                Console.WriteLine($"남은 결제 금액은 {finalPrice}원 입니다");
                int paid = ConsoleInput.ReadIntAtLeast("금액을 넣어주세요 : ", 0);
                finalPrice -= paid;
                if (finalPrice == 0)
                {
                    isPaying = false;
                }
                else if (finalPrice < 0)
                {
                    ConsolePrint.PrintCutLine();
                    finalPrice *= -1;
                    Console.WriteLine($"거스름돈은 {finalPrice}원 입니다.");
                    ConsolePrint.PrintCutLine();
                    isPaying = false;
                }
            }
            ConsolePrint.PrintCutLine();
            Console.WriteLine("결제가 완료되었습니다.");
        }
        ConsolePrint.PrintCutLine();
        Console.WriteLine("이용해주셔서 감사합니다");
    }
}