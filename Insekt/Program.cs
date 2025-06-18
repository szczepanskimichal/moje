using System; // Import the System namespace for basic .NET types and console operations
using System.Collections.Generic; // Import generic collections like List<T>

namespace Insekt // Define the namespace for the application
{
    internal class Program // Main program class
    {
        static void Main(string[] args) // Entry point of the application
        {
            // Create a list of Bug objects, initialized with some predefined insects
            List<Bug> insekter = new List<Bug>
            {
                new Mygg(),      // Add a mosquito
                new Husflue(),   // Add a housefly
                new Edderkopp(), // Add a spider
                new Flaatt(),    // Add a tick
                new Veps()       // Add a wasp
            };

            // Main program loop for the user menu
            while (true)
            {
                Console.WriteLine("\n    InsektOppslagsverket    "); // Display the title
                Console.WriteLine("1. Se liste over insekter");      // Option 1: Show insect list
                Console.WriteLine("2. Legg inn nytt insekt");        // Option 2: Add new insect
                Console.WriteLine("3. Avslutt");                     // Option 3: Exit
                Console.Write("Ditt valg: ");                        // Prompt for user choice
                string valg = Console.ReadLine();                    // Read user input

                if (valg == "1") // If user selects 1: show insect list
                {
                    for (int i = 0; i < insekter.Count; i++) // Iterate through all insects
                        Console.WriteLine($"{i}: {insekter[i].Navn}"); // Display index and name

                    Console.Write("Skriv nummeret for å se mer: "); // Prompt for insect number
                    if (int.TryParse(Console.ReadLine(), out int idx) && idx >= 0 && idx < insekter.Count)
                    {
                        insekter[idx].VisInfo(); // Show details for the selected insect
                    }
                }
                else if (valg == "2") // If user selects 2: add a new insect
                {
                    Bug nyttInsekt = new Bug(); // Create a new Bug object
                    Console.Write("Navn: "); // Prompt for name
                    nyttInsekt.Navn = Console.ReadLine(); // Set name

                    Console.Write("Kan bite (true/false): "); // Prompt if it can bite
                    bool.TryParse(Console.ReadLine(), out bool kanBite); // Parse input
                    nyttInsekt.KanBite = kanBite; // Set property

                    Console.Write("Antall bein: "); // Prompt for number of legs
                    int.TryParse(Console.ReadLine(), out int antallBein); // Parse input
                    nyttInsekt.AntallBein = antallBein; // Set property

                    Console.Write("Kan fly (true/false): "); // Prompt if it can fly
                    bool.TryParse(Console.ReadLine(), out bool kanFly); // Parse input
                    nyttInsekt.KanFly = kanFly; // Set property

                    Console.Write("Plage: "); // Prompt for nuisance description
                    nyttInsekt.Plage = Console.ReadLine(); // Set property

                    Console.Write("Good stuff: "); // Prompt for positive traits
                    nyttInsekt.GoodStuff = Console.ReadLine(); // Set property

                    insekter.Add(nyttInsekt); // Add the new insect to the list
                    Console.WriteLine("Insekt lagt til!"); // Confirm addition
                }
                else if (valg == "3") // If user selects 3: exit
                {
                    Console.WriteLine("Avslutter..."); // Inform about exit
                    break; // Exit the loop and end the program
                }
                else // If user enters an invalid option
                {
                    Console.WriteLine("Ugyldig valg."); // Inform about invalid choice
                }
            }
        }
    }

    // Base class for all insects!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public class Bug
    {
        public string Navn { get; set; } // Name of the insect
        public bool KanBite { get; set; } // Can it bite
        public int AntallBein { get; set; } // Number of legs
        public bool KanFly { get; set; } // Can it fly
        public string Plage { get; set; } // Nuisance description
        public string GoodStuff { get; set; } // Positive traits

        // Method to display detailed information about the insect
        public virtual void VisInfo()
        {
            Console.WriteLine($"\nInsekt: {Navn}"); // Display name
            Console.WriteLine($"- Kan bite: {KanBite}"); // Can it bite
            Console.WriteLine($"- Antall bein: {AntallBein}"); // Number of legs
            Console.WriteLine($"- Kan fly: {KanFly}"); // Can it fly
            Console.WriteLine($"- Plage: {Plage}"); // Nuisance
            Console.WriteLine($"- Good stuff: {GoodStuff}"); // Positive traits
        }
    }

    // Mosquito class
    public class Mygg : Bug
    {
        public Mygg()
        {
            Navn = "Mygg"; // Name
            KanBite = true; // Can bite
            AntallBein = 6; // 6 legs
            KanFly = true; // Can fly
            Plage = "Suger blod, gir kløe"; // Nuisance
            GoodStuff = "Ingen spesifikk nytte kjent"; // Positive traits
        }
    }

    // Housefly class
    public class Husflue : Bug
    {
        public Husflue()
        {
            Navn = "Husflue"; // Name
            KanBite = false; // Cannot bite
            AntallBein = 6; // 6 legs
            KanFly = true; // Can fly
            Plage = "Irriterende, lander på mat"; // Nuisance
            GoodStuff = "Bidrar til nedbrytning"; // Positive traits
        }
    }

    // Spider class
    public class Edderkopp : Bug
    {
        public Edderkopp()
        {
            Navn = "Edderkopp"; // Name
            KanBite = true; // Can bite
            AntallBein = 8; // 8 legs
            KanFly = false; // Cannot fly
            Plage = "Kan skremme folk"; // Nuisance
            GoodStuff = "Spiser insekter"; // Positive traits
        }
    }

    // Tick class
    public class Flaatt : Bug
    {
        public Flaatt()
        {
            Navn = "Flaatt"; // Name
            KanBite = true; // Can bite
            AntallBein = 8; // 8 legs
            KanFly = false; // Cannot fly
            Plage = "Kan spre sykdom"; // Nuisance
            GoodStuff = "Ingen kjent nytte"; // Positive traits
        }
    }

    // Wasp class
    public class Veps : Bug
    {
        public Veps()
        {
            Navn = "Veps"; // Name
            KanBite = true; // Can bite
            AntallBein = 6; // 6 legs
            KanFly = true; // Can fly
            Plage = "Stikker smertefullt"; // Nuisance
            GoodStuff = "Bestøver blomster"; // Positive traits
        }
    }
}