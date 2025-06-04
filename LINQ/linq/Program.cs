
//var numbers = new List<int> { 11, 12, 55, 77, 44,33};

//Console.WriteLine( numbers.IndexOf(12));
//numbers.Sort((a,b)=>b.CompareTo(a));
//Console.WriteLine(string.Join("|| ", numbers));

using System.Linq;

int[] scores = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

//query expression syntax
IEnumerable<string> Query =
    from score in scores
    where score < 100
    orderby score descending
    //select score;
    select $"Score: {score}";

foreach (string s in Query)
{
    Console.WriteLine("||" + s + "||");
}