//StaticClicker.Run();



var clickers = new Clicker[]
{
     new Clicker('a'),
    new Clicker('b'),
    new Clicker('c'),
    new Clicker('d')
};



while (true)
{
    //clicker.ShowPoints();
    //var command = Console.ReadKey();
    //clicker.HandleCommand(command);
    Console.Clear();
    foreach (var clicker in clickers)
    {
        clicker.ShowPoints();
    }

    var command =Console.ReadKey(true);
    foreach (var clicker in clickers)
    {
        clicker.HandleCommand(command);
    }

}