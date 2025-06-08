//using Clicker;

public class StaticClicker
{
    //public static int Points = 0;
    //public static int Upgrade = 1;
    public static SimpleClicker SimpleClicker = new SimpleClicker();
    public static void Run()
    {
        //var points = 0;
        //var upgrade = 1;

        while (true)
        {
            ShowPoints();
            var command = Console.ReadKey(false);
            HandleCommand(command);
            Console.WriteLine();
        }
    }

    private static void HandleCommand(ConsoleKeyInfo command)
    {
        if (command.KeyChar == 'a')
        {
            SimpleClicker.Points += SimpleClicker.Upgrade;
        }
        else if (command.KeyChar == 'A')
        {
            if (SimpleClicker.Points > 0) 
            {
                SimpleClicker.Upgrade++;
                SimpleClicker.Points -= 10;
            }
        }
    }

    private static void ShowPoints()
    {
        Console.Clear();
        Console.WriteLine($"Klikker A Du har {SimpleClicker.Points} poeng. (a=klikk, A=upgrade");
    }
}