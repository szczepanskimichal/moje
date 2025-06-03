Console.WriteLine("Hello Michal");

string firstFriend= "      Darek    ";
//firstFriend = firstFriend.TrimStart();
firstFriend = firstFriend.Trim();


string secondFriend = "             Andrzej                    ";
//Console.WriteLine($"My friends are {firstFriend} and {secondFriend}" );
//Console.WriteLine("my friends: " + firstFriend + " and " + secondFriend.Trim());

string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}";

Console.WriteLine(friends);
friends = friends.Replace("Darek", "Ada");
Console.WriteLine(friends);
Console.WriteLine(friends.Contains("Ada"));
Console.WriteLine(friends.ToUpper());
Console.WriteLine(friends.ToLower());
Console.WriteLine(friends.Length);