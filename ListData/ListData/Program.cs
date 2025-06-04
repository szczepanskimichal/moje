List<string> names = ["<name>", "Ada", "Michal"];

names.Add("John");
names.Add("Jane");
names.Add("Alice");
names.Add("Bob");


//for (int i=0;i<names.Count; i++)
//{
//    Console.WriteLine($"hello {names[i].ToLower()}");
//}



Console.WriteLine(names[0]);
Console.WriteLine(names[2]);
Console.WriteLine(names.IndexOf("Ada"));
Console.WriteLine(names.Contains("Michal"));
Console.WriteLine(names.Count);
//Console.WriteLine(names[names.Count-1]);
Console.WriteLine(names[^1]);//it's the same as names[names.Count-1]!!!Use index from end operator (^) to access the last element in the list


foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}");

}