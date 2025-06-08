public class Clicker
{
    public  int Points; // ze static dzialaja naraz wszystkie guziki!!! tak nie moze byc, musisz wiedziec ze stsic uzywa sie z rozwaga!!!
    public int Upgrade;
    public char ClickCharakter;
    public string PlayerName;

    public Clicker(char clickCharakter, string playerName="")
    {
        PlayerName = playerName;
        ClickCharakter = clickCharakter; 
        Upgrade = 1;
        Points = 0;
    }
    public void ShowPoints()
    {
        //Console.Clear();
        Console.WriteLine($"Klikker {char.ToUpper(ClickCharakter)} Du har {Points} poeng. ({char.ToLower(ClickCharakter)}=klikk, {char.ToUpper(ClickCharakter)}=upgrade)");
    }

    public void HandleCommand(ConsoleKeyInfo command)
    {
        if (command.KeyChar == char.ToLower(ClickCharakter))
        {
            Points += Upgrade;
        }
        else if (command.KeyChar == char.ToUpper(ClickCharakter))
        {
            if (Points > 0)
            {
                Upgrade++;
                Points -= 10;
            }
        }
    }
}