var p1 = new Person("Michal", "Sz", new DateOnly(1986, 08, 15));
var p2 = new Person("Ada", "Sz", new DateOnly(1987, 04, 07));
var p3 = new Person("kazia", "smierdzionczka", new DateOnly(9999, 09, 09));

p1.Pets.Add(new Dog("Kamelka"));
p1.Pets.Add(new Dog("cziczi"));
p2.Pets.Add(new Cat("MIJA"));
p3.Pets.Add(new Cat("KOT"));

List<Person> people = new List<Person> { p1, p2, p3 }; // ✅ Poprawiona inicjalizacja
Console.WriteLine(people.Count);

foreach (var person in people)
{
    Console.WriteLine($"{person}");
    foreach (var pet in person.Pets)
    {
        Console.WriteLine($"{pet}");
    }
}

public class Person(string firstname, string lastname, DateOnly birthday)
{
    public string First { get; } = firstname;
    public string Last { get; } = lastname;
    public DateOnly Birthday { get; } = birthday;
    public List<Pet> Pets { get; } = new();
    public override string ToString()
    {
        return $"Human {First} {Last}";
    }
}

public abstract class Pet(string firstname)
{
    public string First { get; } = firstname;
    public abstract string MakeNoise();  // ✅ poprawiona nazwa
    public override string ToString()
    {
        return $"{First} and I am a {GetType().Name} and I {MakeNoise()}";
    }
}

public class Cat : Pet
{
    public Cat(string firstName) : base(firstName) { }
    public override string MakeNoise() => "meow";
}

public class Dog : Pet
{
    public Dog(string firstName) : base(firstName) { }
    public override string MakeNoise() => "bark";
}
