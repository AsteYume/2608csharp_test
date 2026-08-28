namespace _2608test;

public class ConsolePrint
{
    public static void PrintCutLine()
    {
        Console.WriteLine("========================================");
    }

    public static void PrintMenu(string name)
    {
        Console.WriteLine("["+name+"]");
    }

    public static void PrintKiosk(string name)
    {
        Console.WriteLine(name + " 키오스크");
    }
}