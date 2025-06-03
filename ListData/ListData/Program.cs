List<string> names = ["<name>", "Ada", "Michal"];

names.Add("John");
names.Add("Jane");
names.Add("Alice");
names.Add("Bob");


for (int i=0;i<names.Count; i++)
{
    Console.WriteLine($"hello {names[i].ToLower()}");
}

foreach( var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");
    
}

//it seems to work, I just managed to resolve conflicts on GH, that's cool :)