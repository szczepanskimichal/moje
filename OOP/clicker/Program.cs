//StaticClicker.Run();



using clicker;
using System.Text.Json;

//var scoreFilrContent = File.ReadAllText("scores.json");
//var scores = JsonSerializer.Deserialize<ClickerScore[]>("");
var scoreFileContent = File.ReadAllText("scores.json");
var scores = JsonSerializer.Deserialize<ClickerScore[]>(scoreFileContent, new JsonSerializerOptions { IncludeFields=true});
var clickers = new Clicker[]
{
     new Clicker('a', "Michal"),
    new Clicker('b', "ada"),
    new Clicker('c', "mijcia"),
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
    if(command.Key == ConsoleKey.Escape)
    { break; }
    foreach (var clicker in clickers)
    {
        clicker.HandleCommand(command);
    }

}

var newScores = new List<ClickerScore>();
foreach(var clicker in clickers)
{
    newScores.Add(new ClickerScore
        { 
            Name = clicker.PlayerName,
            Score = clicker.Points
    });
}

File.WriteAllText("scores.json", JsonSerializer.Serialize(newScores, new JsonSerializerOptions
{
    IncludeFields = true
}));
