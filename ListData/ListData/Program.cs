﻿using System.Collections.Immutable;

//List<string> names = ["<name>", "Ada", "Michal"];

//names.Add("John");
//names.Add("Jane");
//names.Add("Alice");
//names.Add("Bob");


//for (int i=0;i<names.Count; i++)
//{
//    Console.WriteLine($"hello {names[i].ToLower()}");
//}



//Console.WriteLine(names[0]);
//Console.WriteLine(names[2]);
//Console.WriteLine(names.IndexOf("Ada"));
//Console.WriteLine(names.Contains("Michal"));
//Console.WriteLine(names.Count);
//Console.WriteLine(names[names.Count-1]);
//Console.WriteLine(names[^1]);//it's the same as names[names.Count-1]!!!Use index from end operator (^) to access the last element in the list/OSTATNI ELEMENT LISTY
//Console.WriteLine(names[^2]);

//var imiona = new List<string> { "Ada", "Michal", "John", "Jane", "Alice", "Bob" }; // Array of strings!!!
////imiona.Add("Kasia");//LIST<T>
//imiona = [..imiona, "Kasia"]; // Adding an element to an array creates a new array

//imiona.Sort();
//foreach (var name in imiona)
//{
//    Console.WriteLine($"Hello {name.ToLower()}");
//}

var numbers = new List<int> { 11, 32, 43, 54, 65 };
Console.WriteLine(numbers.IndexOf(32));
numbers.Sort();
Console.WriteLine(numbers.IndexOf(65));
