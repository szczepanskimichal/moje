namespace Abstrakcja_i_Klasy_Abstrakcyjne
{


    public abstract class Animal
    {
        public string Imie { get; set; }

        public abstract void WydajDzwiek(); // metoda abstrakcyjna – musi być nadpisana
    }

    public class Pies : Animal
    {
        public override void WydajDzwiek()
        {
            Console.WriteLine($"{Imie}: Hau hau!");
        }
    }

    public class Kot : Animal
    {
        public override void WydajDzwiek()
        {
            Console.WriteLine($"{Imie}: Miau miau!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
        {
            new Pies { Imie = "Reksio" },
            new Kot { Imie = "Mruczek" }
        };

            foreach (var animal in animals)
            {
               animal.WydajDzwiek();
            }
        }
    }
}
