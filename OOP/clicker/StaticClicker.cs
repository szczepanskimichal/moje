public class StaticClicker
{
    public static int Points = 0;
    public static int Upgrade = 1;
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
            Points += Upgrade;
        }
        else if (command.KeyChar == 'A')
        {
            if (Points > 0)
            {
                Upgrade++;
                Points -= 10;
            }
        }
    }

    private static void ShowPoints()
    {
        Console.Clear();
        Console.WriteLine($"Klikker A Du har {Points} poeng. (a=klikk, A=upgrade");
    }
}