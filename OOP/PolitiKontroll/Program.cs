using System;
using System.Collections.Generic;

// Klasa reprezentująca kierowcę
class Sjafor
{
    public string Name { get; set; }
    public bool Seatbelt { get; set; }
    public bool UsesPhone { get; set; }
    public bool DriveLicense { get; set; }
    public double AlcoholLevel { get; set; }
    public int Speed { get; set; }

    // Konstruktor przypisujący wartości właściwości kierowcy
    public Sjafor(string name, bool hasSeatbelt, bool usesPhone, bool driverLicense, double alcoholLevel, int speed)
    {
        Name = name;
        Seatbelt = hasSeatbelt;
        UsesPhone = usesPhone;
        DriveLicense = driverLicense;
        AlcoholLevel = alcoholLevel;
        Speed = speed;
    }
}

// Klasa bazowa dla wszystkich policjantów
abstract class Politimann
{
    // Każdy policjant musi mieć własną metodę Check
    //Check to metoda, która wymusza na każdej klasie policjanta własną logikę kontroli kierowcy.
    /// /Dzięki temu każdy policjant sprawdza coś innego, ale wywołuje ich w taki sam sposób.
    /// To klasyczny przykład polimorfizmu w programowaniu obiektowym!!!
    public abstract void Check(Sjafor sjafor);
}

// Policjant sprawdzający pasy i telefon
class SeatbeltAndPhoneCheck : Politimann
{
    public override void Check(Sjafor person)
    {
        Console.WriteLine($"\n{person.Name} blir kontrollert for belte og mobilbruk.");

        // Sprawdzenie pasów i telefonu
        if (!person.Seatbelt || person.UsesPhone)
        {
            Console.WriteLine("-> Regelbrudd:");
            if (!person.Seatbelt)
                Console.WriteLine("   - Mangler bilbelte. BOT!"); // Brak pasów = mandat
            if (person.UsesPhone)
                Console.WriteLine("   - Bruker mobil under kjøring. BOT!"); // Używanie telefonu = mandat
        }
        else
        {
            Console.WriteLine("   - Alt i orden."); // Wszystko ok
        }
    }
}

// Policjant mierzący prędkość
class SpeedCheck : Politimann
{
    public override void Check(Sjafor sjafor)
    {
        Console.WriteLine($"\n{sjafor.Name} blir kontrollert for fart. (Kjører i {sjafor.Speed} km/t)");

        int limit = 60;
        int over = sjafor.Speed - limit;
         
        // Sprawdzenie przekroczenia prędkości
        if (over >= 20)
        {
            Console.WriteLine("-> Kjørt mer enn 20 km/t over grensen. MISTER LAPPEN!"); // Powyżej 20 = utrata prawa jazdy
        }
        else if (over > 0)
        {
            Console.WriteLine("-> Kjørt for fort. BOT!"); // Mniej niż 20 = mandat
        }
        else
        {
            Console.WriteLine("   - Alt i orden.");
        }
    }
}

// Policjant sprawdzający promile i prawo jazdy
class AlcoholAndLicenseCheck : Politimann
{
    public override void Check(Sjafor sjafor)
    {
        Console.WriteLine($"\n{sjafor.Name} blir kontrollert for promille og førerkort.");

        // Sprawdzenie promili
        if (sjafor.AlcoholLevel >= 0.02)
        {
            Console.WriteLine($"-> Alkoholpromille er {sjafor.AlcoholLevel}. MISTER LAPPEN!"); // Powyżej 0.02 = utrata prawa jazdy
        }
        else if (!sjafor.DriveLicense)
        {
            Console.WriteLine("-> Mangler gyldig førerkort. BOT!"); // Brak prawa jazdy = mandat
        }
        else
        {
            Console.WriteLine("   - Alt i orden.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tworzymy listę przykładowych kierowców (mogłaby też być losowana)
        List<Sjafor> drivers = new List<Sjafor>
        {
            new Sjafor("Ola", true, false, true, 3.00, 250),
            new Sjafor("Kari", false, true, true, 0.01, 70),
            new Sjafor("Per", true, false, false, 0.00, 80),
            new Sjafor("Anna", true, true, true, 0.03, 50),
        };

        // Lista policjantów – po kolei każdy kierowca przechodzi przez nich
        List<Politimann> officers = new List<Politimann>
        {
            new SeatbeltAndPhoneCheck(),
            new SpeedCheck(),
            new AlcoholAndLicenseCheck()
        };

        // Pętla po kierowcach – każdy jest sprawdzany przez wszystkich policjantów
        foreach (var driver in drivers)
        {
            Console.WriteLine($"Kontroll av {driver.Name}");
            foreach (var officer in officers)
            {
                officer.Check(driver);
            }
        }

        // Pauza na koniec programu
        Console.WriteLine("Trykk en tast for å avslutte...");
        Console.ReadKey();
    }
}
